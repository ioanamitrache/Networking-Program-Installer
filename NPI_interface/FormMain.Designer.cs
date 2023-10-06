namespace NPI_interface
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonInstallation = new System.Windows.Forms.Button();
            this.buttonHostsConfig = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.buttonHelp);
            this.panelSideMenu.Controls.Add(this.buttonInstallation);
            this.panelSideMenu.Controls.Add(this.buttonHostsConfig);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 553);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHelp.Location = new System.Drawing.Point(0, 190);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonHelp.Size = new System.Drawing.Size(250, 45);
            this.buttonHelp.TabIndex = 7;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonInstallation
            // 
            this.buttonInstallation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInstallation.FlatAppearance.BorderSize = 0;
            this.buttonInstallation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstallation.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonInstallation.Location = new System.Drawing.Point(0, 145);
            this.buttonInstallation.Name = "buttonInstallation";
            this.buttonInstallation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonInstallation.Size = new System.Drawing.Size(250, 45);
            this.buttonInstallation.TabIndex = 5;
            this.buttonInstallation.Text = "Program Installation";
            this.buttonInstallation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInstallation.UseVisualStyleBackColor = true;
            this.buttonInstallation.Click += new System.EventHandler(this.buttonInstallation_Click);
            // 
            // buttonHostsConfig
            // 
            this.buttonHostsConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHostsConfig.FlatAppearance.BorderSize = 0;
            this.buttonHostsConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHostsConfig.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHostsConfig.Location = new System.Drawing.Point(0, 100);
            this.buttonHostsConfig.Name = "buttonHostsConfig";
            this.buttonHostsConfig.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonHostsConfig.Size = new System.Drawing.Size(250, 45);
            this.buttonHostsConfig.TabIndex = 1;
            this.buttonHostsConfig.Text = "Hosts Configuration";
            this.buttonHostsConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHostsConfig.UseVisualStyleBackColor = true;
            this.buttonHostsConfig.Click += new System.EventHandler(this.buttonHostsConfig_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(682, 553);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FormMain";
            this.Text = "Networking Program Installer";
            this.panelSideMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button buttonHostsConfig;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonInstallation;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

