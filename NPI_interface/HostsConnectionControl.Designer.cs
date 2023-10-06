namespace NPI_interface
{
    partial class HostsConnectionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostsConnectionControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHostName = new System.Windows.Forms.Label();
            this.labelIPaddress = new System.Windows.Forms.Label();
            this.labelIsConnected = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelSendingInfo = new System.Windows.Forms.Label();
            this.labelFileStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelHostName
            // 
            this.labelHostName.AutoSize = true;
            this.labelHostName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelHostName.Location = new System.Drawing.Point(79, 6);
            this.labelHostName.Name = "labelHostName";
            this.labelHostName.Size = new System.Drawing.Size(78, 17);
            this.labelHostName.TabIndex = 2;
            this.labelHostName.Text = "Host Name";
            this.labelHostName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelIPaddress
            // 
            this.labelIPaddress.AutoSize = true;
            this.labelIPaddress.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelIPaddress.Location = new System.Drawing.Point(81, 22);
            this.labelIPaddress.Name = "labelIPaddress";
            this.labelIPaddress.Size = new System.Drawing.Size(76, 17);
            this.labelIPaddress.TabIndex = 3;
            this.labelIPaddress.Text = "IP Address";
            this.labelIPaddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelIsConnected
            // 
            this.labelIsConnected.AutoSize = true;
            this.labelIsConnected.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelIsConnected.Location = new System.Drawing.Point(81, 38);
            this.labelIsConnected.Name = "labelIsConnected";
            this.labelIsConnected.Size = new System.Drawing.Size(96, 17);
            this.labelIsConnected.TabIndex = 4;
            this.labelIsConnected.Text = "Is connected?";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(323, 22);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(153, 22);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // labelSendingInfo
            // 
            this.labelSendingInfo.AutoSize = true;
            this.labelSendingInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSendingInfo.Location = new System.Drawing.Point(319, 4);
            this.labelSendingInfo.Name = "labelSendingInfo";
            this.labelSendingInfo.Size = new System.Drawing.Size(94, 17);
            this.labelSendingInfo.TabIndex = 6;
            this.labelSendingInfo.Text = "Sending file...";
            this.labelSendingInfo.Visible = false;
            // 
            // labelFileStatus
            // 
            this.labelFileStatus.AutoSize = true;
            this.labelFileStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFileStatus.Location = new System.Drawing.Point(507, 22);
            this.labelFileStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileStatus.Name = "labelFileStatus";
            this.labelFileStatus.Size = new System.Drawing.Size(48, 17);
            this.labelFileStatus.TabIndex = 7;
            this.labelFileStatus.Text = "Status";
            this.labelFileStatus.Visible = false;
            // 
            // HostsConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelFileStatus);
            this.Controls.Add(this.labelSendingInfo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelIsConnected);
            this.Controls.Add(this.labelIPaddress);
            this.Controls.Add(this.labelHostName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HostsConnectionControl";
            this.Size = new System.Drawing.Size(674, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHostName;
        private System.Windows.Forms.Label labelIPaddress;
        private System.Windows.Forms.Label labelIsConnected;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelSendingInfo;
        private System.Windows.Forms.Label labelFileStatus;
    }
}
