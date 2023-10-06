using NPI_interface.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPI_interface
{
    public partial class FormProgramInstallation : Form
    {
        public String FilePath { get; set; }
        private HostsList AllHosts = HostsList.Instance;

        public FormProgramInstallation()
        {
            InitializeComponent();
            PopulateComboBox(AllHosts);
        }

        public void PopulateComboBox(HostsList hList)
        {
            comboBoxAllHosts.DataSource = hList.list;
            comboBoxAllHosts.DisplayMember = "IPaddress";
            comboBoxAllHosts.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All files (*.*)|*.*";
            openFile.Title = "Choose .msi file";
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string path = openFile.FileName;
                this.FilePath = path;
                textBoxMSIpath.Text = path;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var selectedHost = (Host)comboBoxAllHosts.SelectedItem;
            var control = new HostsConnectionControl(selectedHost);

            bool isDuplicate = false;
            if (selectedHost != null)
            {
                foreach(Control c in flowLayoutPanel.Controls)
                {
                    if (c.GetType() == typeof(HostsConnectionControl))
                    {
                        HostsConnectionControl hcc = (HostsConnectionControl)c;

                        if (hcc.IPaddress == selectedHost.IPaddress)
                        {
                            string message = "Host already added. Please choose another one.";
                            string caption = "Choose another host";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result;

                            isDuplicate = true;

                            // Displays the MessageBox
                            result = MessageBox.Show(message, caption, buttons);
                        }
                    }
                }

                if(!isDuplicate)
                    flowLayoutPanel.Controls.Add(control);
            }
        }

        private void comboBoxAllHosts_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxAllHosts.Text))
            {
                comboBoxAllHosts.Focus();
                errorProviderChooseHost.SetError(comboBoxAllHosts, "You must select a host!");
            }
            else errorProviderChooseHost.SetError(comboBoxAllHosts, null);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxMSIpath.Text == "")
            {
                MessageBox.Show("Please choose a file!");
                return;
            }

            ManagedManager manager = (ManagedManager)ManagedManager.GetInstance();

            int sum = 0;
            foreach (Control c in flowLayoutPanel.Controls)
            {
                if(c.GetType() == typeof(HostsConnectionControl))
                {
                    sum++;
                    int retCode = manager.ServerInitialize();
                    if (retCode != 0)
                    {
                        MessageBox.Show("Server initialization failed!");
                        return;
                    }

                    HostsConnectionControl hcc = (HostsConnectionControl)c;

                    retCode = manager.ServerConnect(hcc.IPaddress);
                    if(retCode == 0) // Connected successfully
                    {
                        String hostName = manager.GetHostName();
                        hcc.UpdateLabels("Connected", hostName);
                        hcc.TransferWillStart();
                        hcc.Update();
                    }
                    else
                    {
                        hcc.NotConnected();
                        hcc.Update();
                        manager.ServerDisconnect();
                        continue;
                    }
                    manager.ActiveHost = hcc;
                    retCode = manager.ServerSendFile(this.FilePath);
                    hcc.UpdateLabelIsConnected("Disconnected");
                    if (retCode != 0) // File sent successfully
                    {
                        hcc.TransferFailed();
                        hcc.Update();
                        continue;
                    }
                    hcc.UpdateDownload(100);
                    hcc.TransferCompleted();
                    hcc.Update();
                    manager.ServerDisconnect();
                }
            }

            if (sum == 0)
            {
                MessageBox.Show("Please add at least one host!");
                return;
            }

            buttonSend.Visible = false;
        }
    }
}
