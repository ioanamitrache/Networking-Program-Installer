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
using System.IO;

namespace NPI_interface
{
    public partial class HostControl : UserControl
    {
        private FlowLayoutPanel flp= null;
        HostsList hl;
        Host host; 

        public Host Host
        {
            get { return host; }
        }

        public HostControl()
        {
            
            InitializeComponent();
        }

        public HostControl(Host host, FlowLayoutPanel flp, HostsList hl) : this()
        {
            this.flp = flp;
            this.hl = hl;
            this.host = host;

            string path = Application.ExecutablePath;
            path = path.Replace("bin\\x86\\Debug\\NPI_interface.exe", String.Empty);
            pictureBox1.Image = Image.FromFile(path + "Resources\\host.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch; 
            
            labelIPaddress.Text = host.IPaddress;

            this.LostFocus += FocusLostEvent;
        }

        private void SelectControl(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            this.Focus();
            this.BackColor = System.Drawing.Color.Teal;

            ContextMenu deleteMenu = new ContextMenu();
            MenuItem deleteItem = new MenuItem("Delete", new System.EventHandler(this.onDeleteMenuItem_Click));
            deleteMenu.MenuItems.Add(deleteItem);
            deleteMenu.Show(this, new Point(e.X, e.Y));

            // When the deleteMenu disappears aka a function was selected or click outside
            this.Parent.Focus();
        }

        private void FocusLostEvent(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void onDeleteMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Transparent;

            this.flp.Controls.Remove(this);
            this.hl.Delete(this.host);

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SelectControl(e);
        }

        private void HostControl_MouseClick(object sender, MouseEventArgs e)
        {
            SelectControl(e);
        }

        private void labelIPaddress_MouseClick(object sender, MouseEventArgs e)
        {
            SelectControl(e);
        }
    }
}
