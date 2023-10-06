namespace NPI_interface
{
    partial class HostControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelIPaddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(18, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // labelIPaddress
            // 
            this.labelIPaddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIPaddress.AutoSize = true;
            this.labelIPaddress.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelIPaddress.Location = new System.Drawing.Point(18, 65);
            this.labelIPaddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIPaddress.Name = "labelIPaddress";
            this.labelIPaddress.Size = new System.Drawing.Size(58, 13);
            this.labelIPaddress.TabIndex = 2;
            this.labelIPaddress.Text = "IP Address";
            this.labelIPaddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelIPaddress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelIPaddress_MouseClick);
            // 
            // HostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelIPaddress);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HostControl";
            this.Size = new System.Drawing.Size(93, 91);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HostControl_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelIPaddress;
    }
}
