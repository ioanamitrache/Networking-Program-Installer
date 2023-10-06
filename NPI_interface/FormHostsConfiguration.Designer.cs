namespace NPI_interface
{
    partial class FormHostsConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHostsConfiguration));
            this.buttonClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportHostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importHostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTotxtFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNewHost = new System.Windows.Forms.Label();
            this.buttonAddHost = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(0, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(44, 24);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(583, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportHostsToolStripMenuItem,
            this.importHostsToolStripMenuItem,
            this.saveTotxtFileToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.optionsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exportHostsToolStripMenuItem
            // 
            this.exportHostsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.exportHostsToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.exportHostsToolStripMenuItem.Name = "exportHostsToolStripMenuItem";
            this.exportHostsToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.exportHostsToolStripMenuItem.Text = "Export Hosts..";
            this.exportHostsToolStripMenuItem.Click += new System.EventHandler(this.exportHostsToolStripMenuItem_Click);
            // 
            // importHostsToolStripMenuItem
            // 
            this.importHostsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.importHostsToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.importHostsToolStripMenuItem.Name = "importHostsToolStripMenuItem";
            this.importHostsToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.importHostsToolStripMenuItem.Text = "Import Hosts..";
            this.importHostsToolStripMenuItem.Click += new System.EventHandler(this.importHostsToolStripMenuItem_Click);
            // 
            // saveTotxtFileToolStripMenuItem
            // 
            this.saveTotxtFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.saveTotxtFileToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveTotxtFileToolStripMenuItem.Name = "saveTotxtFileToolStripMenuItem";
            this.saveTotxtFileToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.saveTotxtFileToolStripMenuItem.Text = "Save to .txt File..";
            this.saveTotxtFileToolStripMenuItem.Click += new System.EventHandler(this.saveTotxtFileToolStripMenuItem_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.flowLayoutPanel.Controls.Add(this.panel1);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(583, 362);
            this.flowLayoutPanel.TabIndex = 4;
            this.flowLayoutPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNewHost);
            this.panel1.Controls.Add(this.buttonAddHost);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 116);
            this.panel1.TabIndex = 8;
            // 
            // labelNewHost
            // 
            this.labelNewHost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNewHost.AutoSize = true;
            this.labelNewHost.BackColor = System.Drawing.Color.Transparent;
            this.labelNewHost.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelNewHost.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelNewHost.Location = new System.Drawing.Point(4, 94);
            this.labelNewHost.Name = "labelNewHost";
            this.labelNewHost.Size = new System.Drawing.Size(97, 17);
            this.labelNewHost.TabIndex = 6;
            this.labelNewHost.Text = "Add New Host";
            this.labelNewHost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAddHost
            // 
            this.buttonAddHost.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddHost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddHost.BackgroundImage")));
            this.buttonAddHost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddHost.FlatAppearance.BorderSize = 0;
            this.buttonAddHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddHost.Location = new System.Drawing.Point(0, 2);
            this.buttonAddHost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddHost.Name = "buttonAddHost";
            this.buttonAddHost.Size = new System.Drawing.Size(107, 89);
            this.buttonAddHost.TabIndex = 7;
            this.buttonAddHost.UseVisualStyleBackColor = false;
            this.buttonAddHost.Click += new System.EventHandler(this.buttonAddHost_Click);
            // 
            // FormHostsConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(583, 390);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHostsConfiguration";
            this.Text = "Hosts Configuration";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportHostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importHostsToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button buttonAddHost;
        private System.Windows.Forms.Label labelNewHost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem saveTotxtFileToolStripMenuItem;
    }
}