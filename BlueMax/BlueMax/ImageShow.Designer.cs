namespace BlueMax
{
    partial class ImageShow
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
            this.pbShowImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbShowImage
            // 
            this.pbShowImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbShowImage.Location = new System.Drawing.Point(0, 0);
            this.pbShowImage.Name = "pbShowImage";
            this.pbShowImage.Size = new System.Drawing.Size(665, 507);
            this.pbShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowImage.TabIndex = 0;
            this.pbShowImage.TabStop = false;
            // 
            // ImageShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 507);
            this.Controls.Add(this.pbShowImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "ImageShow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Show";
            ((System.ComponentModel.ISupportInitialize)(this.pbShowImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbShowImage;
    }
}