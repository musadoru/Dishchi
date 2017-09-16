namespace BlueMax
{
    partial class XRayEdit
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trckBarBrightness = new DevExpress.XtraEditors.TrackBarControl();
            this.trckBarContrast = new DevExpress.XtraEditors.TrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBarBrightness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBarContrast.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trckBarBrightness
            // 
            this.trckBarBrightness.Location = new System.Drawing.Point(12, 253);
            this.trckBarBrightness.Name = "trckBarBrightness";
            this.trckBarBrightness.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trckBarBrightness.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trckBarBrightness.Properties.Minimum = -10;
            this.trckBarBrightness.Size = new System.Drawing.Size(345, 45);
            this.trckBarBrightness.TabIndex = 1;
            this.trckBarBrightness.Visible = false;
            this.trckBarBrightness.EditValueChanged += new System.EventHandler(this.trckBarBrightness_EditValueChanged);
            // 
            // trckBarContrast
            // 
            this.trckBarContrast.Location = new System.Drawing.Point(42, 168);
            this.trckBarContrast.Name = "trckBarContrast";
            this.trckBarContrast.Properties.AccessibleDescription = "";
            this.trckBarContrast.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trckBarContrast.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trckBarContrast.Properties.Minimum = -10;
            this.trckBarContrast.Size = new System.Drawing.Size(345, 45);
            this.trckBarContrast.TabIndex = 2;
            this.trckBarContrast.Visible = false;
            this.trckBarContrast.EditValueChanged += new System.EventHandler(this.trckBarContrast_EditValueChanged);
            // 
            // XRayEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 466);
            this.Controls.Add(this.trckBarContrast);
            this.Controls.Add(this.trckBarBrightness);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "XRayEdit";
            this.ShowIcon = false;
            this.Text = "XRayEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.XRayEdit_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBarBrightness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBarContrast.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBarContrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TrackBarControl trckBarBrightness;
        private DevExpress.XtraEditors.TrackBarControl trckBarContrast;


    }
}