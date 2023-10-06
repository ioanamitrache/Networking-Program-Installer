using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPI_interface.Classes;

namespace NPI_interface
{
    public partial class HostsConnectionControl : UserControl
    {

        public string IPaddress {get;}

        public HostsConnectionControl()
        {
            InitializeComponent();
        }

        public HostsConnectionControl(Host host) : this()
        {
            this.IPaddress = null;
            if (host != null)
            {
                this.IPaddress = host.IPaddress;

                string path = Application.ExecutablePath;
                path = path.Replace("bin\\x86\\Debug\\NPI_interface.exe", String.Empty);
                pictureBox1.Image = Image.FromFile(path + "Resources\\host.png");
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                labelHostName.Text = host.HostName;
                labelIPaddress.Text = host.IPaddress;

                if (host.IsConnected)
                    labelIsConnected.Text = "Connected";
                else
                    labelIsConnected.Text = "Not Connected";
            }
        }

        public void UpdateLabels(String labelIsConnectedText, String labelHostNameText)
        {
            labelIsConnected.Text = labelIsConnectedText;
            labelHostName.Text = labelHostNameText;
        }

        public void UpdateLabelIsConnected(String text)
        {
            labelIsConnected.Text = text;
        }

        public void UpdateLabelFileStatus(String text)
        {
            labelFileStatus.Text = text;
        }

        public void NotConnected()
        {
            labelFileStatus.Visible = true;
            labelFileStatus.Text = "Connection Failed";
            labelFileStatus.ForeColor = Color.Red;
        }

        public void TransferFailed()
        {
            labelFileStatus.Visible = true;
            labelFileStatus.Text = "Transfer Failed";
            labelFileStatus.ForeColor = Color.Red;
        }

        public void TransferWillStart()
        {
            progressBar1.Visible = true;
            labelSendingInfo.Visible = true;
            labelFileStatus.Visible = true;
            labelSendingInfo.Text = "Sending...";
            labelFileStatus.Text = "Transferring file";
            labelFileStatus.ForeColor = Color.Blue;
        }

        public void TransferCompleted()
        {
            labelFileStatus.Visible = true;
            labelFileStatus.Text = "Completed";
            labelSendingInfo.Text = "";
            labelFileStatus.ForeColor = Color.Green;
        }

        public void UpdateDownload(int percentage)
        {
            if (progressBar1.Value == percentage)
                return;
            progressBar1.Value = percentage;
            Update();
        }
    }
}
