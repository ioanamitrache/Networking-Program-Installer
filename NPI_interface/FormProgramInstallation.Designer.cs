namespace NPI_interface
{
    partial class FormProgramInstallation
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
            this.components = new System.ComponentModel.Container();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelFileHostChoose = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxAllHosts = new System.Windows.Forms.ComboBox();
            this.labelChooseHost = new System.Windows.Forms.Label();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.textBoxMSIpath = new System.Windows.Forms.TextBox();
            this.labelChoosePath = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProviderChooseHost = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.buttonSend = new System.Windows.Forms.Button();
            this.panelFileHostChoose.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChooseHost)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(1, 1);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(33, 18);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelFileHostChoose
            // 
            this.panelFileHostChoose.BackColor = System.Drawing.Color.Transparent;
            this.panelFileHostChoose.Controls.Add(this.buttonSend);
            this.panelFileHostChoose.Controls.Add(this.buttonAdd);
            this.panelFileHostChoose.Controls.Add(this.comboBoxAllHosts);
            this.panelFileHostChoose.Controls.Add(this.labelChooseHost);
            this.panelFileHostChoose.Controls.Add(this.buttonChooseFile);
            this.panelFileHostChoose.Controls.Add(this.textBoxMSIpath);
            this.panelFileHostChoose.Controls.Add(this.labelChoosePath);
            this.panelFileHostChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFileHostChoose.Location = new System.Drawing.Point(0, 0);
            this.panelFileHostChoose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFileHostChoose.Name = "panelFileHostChoose";
            this.panelFileHostChoose.Size = new System.Drawing.Size(437, 119);
            this.panelFileHostChoose.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAdd.Location = new System.Drawing.Point(285, 76);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(74, 20);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxAllHosts
            // 
            this.comboBoxAllHosts.FormattingEnabled = true;
            this.comboBoxAllHosts.Location = new System.Drawing.Point(45, 77);
            this.comboBoxAllHosts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAllHosts.Name = "comboBoxAllHosts";
            this.comboBoxAllHosts.Size = new System.Drawing.Size(237, 21);
            this.comboBoxAllHosts.TabIndex = 5;
            this.comboBoxAllHosts.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxAllHosts_Validating);
            // 
            // labelChooseHost
            // 
            this.labelChooseHost.AutoSize = true;
            this.labelChooseHost.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelChooseHost.Location = new System.Drawing.Point(42, 63);
            this.labelChooseHost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChooseHost.Name = "labelChooseHost";
            this.labelChooseHost.Size = new System.Drawing.Size(114, 13);
            this.labelChooseHost.TabIndex = 4;
            this.labelChooseHost.Text = "Choose and Add Host:";
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.buttonChooseFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseFile.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonChooseFile.Location = new System.Drawing.Point(285, 34);
            this.buttonChooseFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(74, 20);
            this.buttonChooseFile.TabIndex = 2;
            this.buttonChooseFile.Text = "Choose File..";
            this.buttonChooseFile.UseVisualStyleBackColor = false;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // textBoxMSIpath
            // 
            this.textBoxMSIpath.Location = new System.Drawing.Point(45, 36);
            this.textBoxMSIpath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMSIpath.Name = "textBoxMSIpath";
            this.textBoxMSIpath.Size = new System.Drawing.Size(237, 20);
            this.textBoxMSIpath.TabIndex = 1;
            // 
            // labelChoosePath
            // 
            this.labelChoosePath.AutoSize = true;
            this.labelChoosePath.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelChoosePath.Location = new System.Drawing.Point(42, 21);
            this.labelChoosePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChoosePath.Name = "labelChoosePath";
            this.labelChoosePath.Size = new System.Drawing.Size(86, 13);
            this.labelChoosePath.TabIndex = 0;
            this.labelChoosePath.Text = "Choose .msi File:";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.panelContainer.Controls.Add(this.flowLayoutPanel);
            this.panelContainer.Controls.Add(this.panelFileHostChoose);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 24);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(437, 293);
            this.panelContainer.TabIndex = 6;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 119);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(437, 174);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // errorProviderChooseHost
            // 
            this.errorProviderChooseHost.ContainerControl = this;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(437, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.buttonSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSend.Location = new System.Drawing.Point(363, 76);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(74, 20);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // FormProgramInstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 317);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormProgramInstallation";
            this.Text = "FormProgramInstallation";
            this.panelFileHostChoose.ResumeLayout(false);
            this.panelFileHostChoose.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChooseHost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelFileHostChoose;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.TextBox textBoxMSIpath;
        private System.Windows.Forms.Label labelChoosePath;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxAllHosts;
        private System.Windows.Forms.Label labelChooseHost;
        private System.Windows.Forms.ErrorProvider errorProviderChooseHost;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button buttonSend;
    }
}