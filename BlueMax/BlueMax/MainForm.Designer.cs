namespace BlueMax
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pbBtnPatient = new System.Windows.Forms.PictureBox();
            this.pbBtnInfo = new System.Windows.Forms.PictureBox();
            this.pbBtnSettings = new System.Windows.Forms.PictureBox();
            this.pbBtnImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImage = global::BlueMax.Properties.Resources.bluemax_background;
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.panelControl1.Controls.Add(this.pbBtnPatient);
            this.panelControl1.Controls.Add(this.pbBtnInfo);
            this.panelControl1.Controls.Add(this.pbBtnSettings);
            this.panelControl1.Controls.Add(this.pbBtnImage);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1100, 507);
            this.panelControl1.TabIndex = 0;
            // 
            // pbBtnPatient
            // 
            this.pbBtnPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBtnPatient.BackColor = System.Drawing.Color.Transparent;
            this.pbBtnPatient.Image = global::BlueMax.Properties.Resources.btn_patient;
            this.pbBtnPatient.Location = new System.Drawing.Point(892, 48);
            this.pbBtnPatient.Name = "pbBtnPatient";
            this.pbBtnPatient.Size = new System.Drawing.Size(196, 87);
            this.pbBtnPatient.TabIndex = 4;
            this.pbBtnPatient.TabStop = false;
            this.pbBtnPatient.Click += new System.EventHandler(this.pbBtnPatient_Click);
            // 
            // pbBtnInfo
            // 
            this.pbBtnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBtnInfo.BackColor = System.Drawing.Color.Transparent;
            this.pbBtnInfo.Image = ((System.Drawing.Image)(resources.GetObject("pbBtnInfo.Image")));
            this.pbBtnInfo.Location = new System.Drawing.Point(892, 327);
            this.pbBtnInfo.Name = "pbBtnInfo";
            this.pbBtnInfo.Size = new System.Drawing.Size(196, 87);
            this.pbBtnInfo.TabIndex = 3;
            this.pbBtnInfo.TabStop = false;
            this.pbBtnInfo.Click += new System.EventHandler(this.pbBtnInfo_Click);
            // 
            // pbBtnSettings
            // 
            this.pbBtnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBtnSettings.BackColor = System.Drawing.Color.Transparent;
            this.pbBtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("pbBtnSettings.Image")));
            this.pbBtnSettings.Location = new System.Drawing.Point(892, 234);
            this.pbBtnSettings.Name = "pbBtnSettings";
            this.pbBtnSettings.Size = new System.Drawing.Size(196, 87);
            this.pbBtnSettings.TabIndex = 2;
            this.pbBtnSettings.TabStop = false;
            this.pbBtnSettings.Click += new System.EventHandler(this.pbBtnSettings_Click);
            // 
            // pbBtnImage
            // 
            this.pbBtnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBtnImage.BackColor = System.Drawing.Color.Transparent;
            this.pbBtnImage.Image = ((System.Drawing.Image)(resources.GetObject("pbBtnImage.Image")));
            this.pbBtnImage.Location = new System.Drawing.Point(892, 141);
            this.pbBtnImage.Name = "pbBtnImage";
            this.pbBtnImage.Size = new System.Drawing.Size(196, 87);
            this.pbBtnImage.TabIndex = 1;
            this.pbBtnImage.TabStop = false;
            this.pbBtnImage.Click += new System.EventHandler(this.pbBtnImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::BlueMax.Properties.Resources.footer_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 420);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(1100, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 507);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "BlueMax MAXIRAY 2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbBtnImage;
        private System.Windows.Forms.PictureBox pbBtnInfo;
        private System.Windows.Forms.PictureBox pbBtnSettings;
        private System.Windows.Forms.PictureBox pbBtnPatient;




    }
}
