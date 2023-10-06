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
    public partial class FormMain : Form
    {

        private HostsList AllHosts;
        public FormMain()
        {
            InitializeComponent();
            AllHosts = HostsList.Instance;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonHostsConfig_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHostsConfiguration(null, false));
        }

        private void buttonInstallation_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProgramInstallation());
        }
    }
}
