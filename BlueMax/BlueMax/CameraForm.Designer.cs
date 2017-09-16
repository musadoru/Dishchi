namespace BlueMax
{
    partial class CameraForm
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
            this.pbCameraLive = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCapture = new DevExpress.XtraEditors.SimpleButton();
            this.btnCameraFreeze = new DevExpress.XtraEditors.SimpleButton();
            this.btnCameraStop = new DevExpress.XtraEditors.SimpleButton();
            this.btnCameraStart = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCameraItems = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCameraLive
            // 
            this.pbCameraLive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbCameraLive.Location = new System.Drawing.Point(103, 108);
            this.pbCameraLive.Name = "pbCameraLive";
            this.pbCameraLive.Size = new System.Drawing.Size(640, 480);
            this.pbCameraLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCameraLive.TabIndex = 2;
            this.pbCameraLive.TabStop = false;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = global::BlueMax.Properties.Resources.close_button;
            this.pbClose.Location = new System.Drawing.Point(803, 30);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(48, 48);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnCapture);
            this.groupControl1.Controls.Add(this.btnCameraFreeze);
            this.groupControl1.Controls.Add(this.btnCameraStop);
            this.groupControl1.Controls.Add(this.btnCameraStart);
            this.groupControl1.Controls.Add(this.cmbCameraItems);
            this.groupControl1.Controls.Add(this.pbClose);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(864, 89);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(666, 30);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(113, 48);
            this.btnCapture.TabIndex = 7;
            this.btnCapture.Text = "Kaydet";
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnCameraFreeze
            // 
            this.btnCameraFreeze.Location = new System.Drawing.Point(529, 30);
            this.btnCameraFreeze.Name = "btnCameraFreeze";
            this.btnCameraFreeze.Size = new System.Drawing.Size(113, 48);
            this.btnCameraFreeze.TabIndex = 6;
            this.btnCameraFreeze.Text = "Yakala";
            this.btnCameraFreeze.Click += new System.EventHandler(this.btnCameraFreeze_Click);
            // 
            // btnCameraStop
            // 
            this.btnCameraStop.Location = new System.Drawing.Point(392, 30);
            this.btnCameraStop.Name = "btnCameraStop";
            this.btnCameraStop.Size = new System.Drawing.Size(113, 48);
            this.btnCameraStop.TabIndex = 5;
            this.btnCameraStop.Text = "Durdur";
            this.btnCameraStop.Click += new System.EventHandler(this.btnCameraStop_Click);
            // 
            // btnCameraStart
            // 
            this.btnCameraStart.Location = new System.Drawing.Point(255, 30);
            this.btnCameraStart.Name = "btnCameraStart";
            this.btnCameraStart.Size = new System.Drawing.Size(113, 48);
            this.btnCameraStart.TabIndex = 4;
            this.btnCameraStart.Text = "Başlat";
            this.btnCameraStart.Click += new System.EventHandler(this.btnCameraStart_Click);
            // 
            // cmbCameraItems
            // 
            this.cmbCameraItems.FormattingEnabled = true;
            this.cmbCameraItems.ItemHeight = 13;
            this.cmbCameraItems.Location = new System.Drawing.Point(12, 41);
            this.cmbCameraItems.Name = "cmbCameraItems";
            this.cmbCameraItems.Size = new System.Drawing.Size(209, 21);
            this.cmbCameraItems.TabIndex = 3;
            // 
            // CameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 600);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pbCameraLive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CameraForm";
            this.Text = "CameraForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CameraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCameraLive;
        private System.Windows.Forms.PictureBox pbClose;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cmbCameraItems;
        private DevExpress.XtraEditors.SimpleButton btnCapture;
        private DevExpress.XtraEditors.SimpleButton btnCameraFreeze;
        private DevExpress.XtraEditors.SimpleButton btnCameraStop;
        private DevExpress.XtraEditors.SimpleButton btnCameraStart;
    }
}