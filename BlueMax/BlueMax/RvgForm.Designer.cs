namespace BlueMax
{
    partial class RvgForm
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnGreen = new DevExpress.XtraEditors.SimpleButton();
            this.btnBlue = new DevExpress.XtraEditors.SimpleButton();
            this.btnRed = new DevExpress.XtraEditors.SimpleButton();
            this.btnHighPass2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnHighPass1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEmboss2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEmboss = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblBrightness = new DevExpress.XtraEditors.LabelControl();
            this.trackBarBrightness = new DevExpress.XtraEditors.TrackBarControl();
            this.btnDefault = new DevExpress.XtraEditors.SimpleButton();
            this.btnInvert = new DevExpress.XtraEditors.SimpleButton();
            this.btnRotateVertical = new DevExpress.XtraEditors.SimpleButton();
            this.btnRotateHorizontal = new DevExpress.XtraEditors.SimpleButton();
            this.btnRotateLeft = new DevExpress.XtraEditors.SimpleButton();
            this.btnRotateRight = new DevExpress.XtraEditors.SimpleButton();
            this.pbCapture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.pbCapture);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1164, 672);
            this.splitContainerControl1.SplitterPosition = 350;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnGreen);
            this.groupControl1.Controls.Add(this.btnBlue);
            this.groupControl1.Controls.Add(this.btnRed);
            this.groupControl1.Controls.Add(this.btnHighPass2);
            this.groupControl1.Controls.Add(this.btnHighPass1);
            this.groupControl1.Controls.Add(this.btnEmboss2);
            this.groupControl1.Controls.Add(this.btnEmboss);
            this.groupControl1.Controls.Add(this.btnStart);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.btnDefault);
            this.groupControl1.Controls.Add(this.btnInvert);
            this.groupControl1.Controls.Add(this.btnRotateVertical);
            this.groupControl1.Controls.Add(this.btnRotateHorizontal);
            this.groupControl1.Controls.Add(this.btnRotateLeft);
            this.groupControl1.Controls.Add(this.btnRotateRight);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(350, 672);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Görüntü İşlemleri";
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(17, 605);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(75, 23);
            this.btnGreen.TabIndex = 17;
            this.btnGreen.Text = "Green";
            this.btnGreen.Visible = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(17, 582);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBlue.TabIndex = 16;
            this.btnBlue.Text = "Blue";
            this.btnBlue.Visible = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(17, 559);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 15;
            this.btnRed.Text = "Red";
            this.btnRed.Visible = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnHighPass2
            // 
            this.btnHighPass2.Location = new System.Drawing.Point(17, 536);
            this.btnHighPass2.Name = "btnHighPass2";
            this.btnHighPass2.Size = new System.Drawing.Size(75, 23);
            this.btnHighPass2.TabIndex = 14;
            this.btnHighPass2.Text = "High Pass 2";
            this.btnHighPass2.Visible = false;
            this.btnHighPass2.Click += new System.EventHandler(this.btnHighPass2_Click);
            // 
            // btnHighPass1
            // 
            this.btnHighPass1.Location = new System.Drawing.Point(17, 513);
            this.btnHighPass1.Name = "btnHighPass1";
            this.btnHighPass1.Size = new System.Drawing.Size(75, 23);
            this.btnHighPass1.TabIndex = 13;
            this.btnHighPass1.Text = "High Pass 1";
            this.btnHighPass1.Visible = false;
            this.btnHighPass1.Click += new System.EventHandler(this.btnHighPass1_Click);
            // 
            // btnEmboss2
            // 
            this.btnEmboss2.Location = new System.Drawing.Point(17, 490);
            this.btnEmboss2.Name = "btnEmboss2";
            this.btnEmboss2.Size = new System.Drawing.Size(75, 23);
            this.btnEmboss2.TabIndex = 12;
            this.btnEmboss2.Text = "Emboss 2";
            this.btnEmboss2.Visible = false;
            this.btnEmboss2.Click += new System.EventHandler(this.btnEmboss2_Click);
            // 
            // btnEmboss
            // 
            this.btnEmboss.Location = new System.Drawing.Point(17, 467);
            this.btnEmboss.Name = "btnEmboss";
            this.btnEmboss.Size = new System.Drawing.Size(75, 23);
            this.btnEmboss.TabIndex = 11;
            this.btnEmboss.Text = "Emboss";
            this.btnEmboss.Visible = false;
            this.btnEmboss.Click += new System.EventHandler(this.btnEmboss_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(30, 227);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(280, 46);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Başlat";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblBrightness);
            this.groupControl2.Controls.Add(this.trackBarBrightness);
            this.groupControl2.Location = new System.Drawing.Point(14, 314);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(321, 134);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Parlaklık";
            // 
            // lblBrightness
            // 
            this.lblBrightness.Location = new System.Drawing.Point(154, 98);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(6, 13);
            this.lblBrightness.TabIndex = 3;
            this.lblBrightness.Text = "0";
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.EditValue = -100;
            this.trackBarBrightness.Location = new System.Drawing.Point(5, 47);
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarBrightness.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trackBarBrightness.Properties.Maximum = 100;
            this.trackBarBrightness.Properties.Minimum = -100;
            this.trackBarBrightness.Size = new System.Drawing.Size(311, 45);
            this.trackBarBrightness.TabIndex = 1;
            this.trackBarBrightness.Value = -100;
            this.trackBarBrightness.EditValueChanged += new System.EventHandler(this.trackBarBrightness_EditValueChanged);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(30, 160);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(128, 46);
            this.btnDefault.TabIndex = 5;
            this.btnDefault.Text = "Orjinal Görüntü";
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(182, 160);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(128, 46);
            this.btnInvert.TabIndex = 4;
            this.btnInvert.Text = "Negatif";
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnRotateVertical
            // 
            this.btnRotateVertical.Location = new System.Drawing.Point(182, 100);
            this.btnRotateVertical.Name = "btnRotateVertical";
            this.btnRotateVertical.Size = new System.Drawing.Size(128, 46);
            this.btnRotateVertical.TabIndex = 3;
            this.btnRotateVertical.Text = "Dikey Çevir";
            this.btnRotateVertical.Click += new System.EventHandler(this.btnRotateVertical_Click);
            // 
            // btnRotateHorizontal
            // 
            this.btnRotateHorizontal.Location = new System.Drawing.Point(30, 100);
            this.btnRotateHorizontal.Name = "btnRotateHorizontal";
            this.btnRotateHorizontal.Size = new System.Drawing.Size(128, 46);
            this.btnRotateHorizontal.TabIndex = 2;
            this.btnRotateHorizontal.Text = "Yatay Çevir";
            this.btnRotateHorizontal.Click += new System.EventHandler(this.btnRotateHorizontal_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.Location = new System.Drawing.Point(182, 40);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(128, 46);
            this.btnRotateLeft.TabIndex = 1;
            this.btnRotateLeft.Text = "-90 Sola Çevir";
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.Location = new System.Drawing.Point(30, 40);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(128, 46);
            this.btnRotateRight.TabIndex = 0;
            this.btnRotateRight.Text = "+90 Sağa Çevir";
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // pbCapture
            // 
            this.pbCapture.Location = new System.Drawing.Point(24, 40);
            this.pbCapture.Name = "pbCapture";
            this.pbCapture.Size = new System.Drawing.Size(626, 626);
            this.pbCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCapture.TabIndex = 0;
            this.pbCapture.TabStop = false;
            // 
            // RvgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 672);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RvgForm";
            this.ShowIcon = false;
            this.Text = "RvgForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RvgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.PictureBox pbCapture;
        private DevExpress.XtraEditors.SimpleButton btnRotateVertical;
        private DevExpress.XtraEditors.SimpleButton btnRotateHorizontal;
        private DevExpress.XtraEditors.SimpleButton btnRotateLeft;
        private DevExpress.XtraEditors.SimpleButton btnRotateRight;
        private DevExpress.XtraEditors.SimpleButton btnInvert;
        private DevExpress.XtraEditors.SimpleButton btnDefault;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TrackBarControl trackBarBrightness;
        private DevExpress.XtraEditors.LabelControl lblBrightness;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.SimpleButton btnGreen;
        private DevExpress.XtraEditors.SimpleButton btnBlue;
        private DevExpress.XtraEditors.SimpleButton btnRed;
        private DevExpress.XtraEditors.SimpleButton btnHighPass2;
        private DevExpress.XtraEditors.SimpleButton btnHighPass1;
        private DevExpress.XtraEditors.SimpleButton btnEmboss2;
        private DevExpress.XtraEditors.SimpleButton btnEmboss;
    }
}