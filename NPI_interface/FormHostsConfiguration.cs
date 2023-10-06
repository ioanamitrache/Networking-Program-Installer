using NPI_interface.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NPI_interface
{
    public partial class FormHostsConfiguration : Form
    {

        private HostsList AllHosts = HostsList.Instance; 
        private Host NewHost;


        public FormHostsConfiguration(Host host, bool isHostAdded)
        {
            this.NewHost = host;
            InitializeComponent();
            LoadHostsList();
        }

        private void LoadHostsList()
        {
            for (int i = 0; i < AllHosts.Count(); i++)
            {
                bool HostExists = false;
                foreach (var c in flowLayoutPanel.Controls)
                {
                    if (c.GetType() == typeof(HostControl))
                    {
                        HostControl control = (HostControl)c;
                        if (control.Host.IPaddress == AllHosts.GetAt(i).IPaddress)
                            HostExists = true;
                    }
                }
                if(!HostExists)
                {
                    HostControl NewControl = new HostControl(AllHosts.GetAt(i), flowLayoutPanel, AllHosts);
                    flowLayoutPanel.Controls.Add(NewControl);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddHost_Click(object sender, EventArgs e)
        {
            FormNewHost newFormDlg = new FormNewHost();
            DialogResult dlgRes = newFormDlg.ShowDialog(this);

            if (dlgRes == DialogResult.OK && newFormDlg.host != null)
            {
                // Add the new host in the list
                AllHosts.Add(newFormDlg.host);
                // Creating and adding a user control related to the newly added host
                var control = new HostControl(newFormDlg.host, flowLayoutPanel, AllHosts);
                flowLayoutPanel.Controls.Add(control);
            }
        }

        private void exportHostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Export Hosts";
            saveFile.Filter = "All XML files (*.xml)|*.xml";
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string path = saveFile.FileName;
                XmlSerializer serializer = new XmlSerializer(typeof(List<Host>));
                FileStream fileStream = new FileStream(path, FileMode.Create);

                serializer.Serialize(fileStream, AllHosts.list);
                fileStream.Close();
                
            }
        }

        private void importHostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All XML files (*.xml)|*.xml";
            openFile.Title = "Import Hosts";
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string path = openFile.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(List<Host>));
                FileStream fileStream = new FileStream(path, FileMode.Open);

                List<Host> ImportedList = (List<Host>)serializer.Deserialize(fileStream);

                if (AllHosts.Count() > 0)
                {
                    foreach(Host h in ImportedList)
                    {
                        bool HostExists = false;
                        for (int i = 0; i < AllHosts.Count(); i++)
                        {
                            if(AllHosts.GetAt(i).IPaddress == h.IPaddress)
                            {
                                HostExists = true;
                                break;
                            }
                        }
                        if (!HostExists)
                            AllHosts.list.Add(h);
                    }
                }
                else
                {
                    AllHosts.list = ImportedList;
                }
                
                
                LoadHostsList();
                fileStream.Close();
            }
        }

        private void saveTotxtFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save Hosts To Txt File";
            saveFile.Filter = "All text files (*.txt)|*.txt";
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFile.FileName);
                foreach (Host h in AllHosts.list)
                {
                    if (h.HostName == null)
                        h.HostName = "unknown";
                    writer.Write(h.IPaddress + " " + h.HostName + " " + h.IsConnected + "\n");
                }
                writer.Close();
            }

        }

        private void flowLayoutPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

        }
    }
}
