namespace BlueMax
{
    partial class XRayEditMain
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEmboss = new DevExpress.XtraEditors.SimpleButton();
            this.btnEmboss2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnHighPass1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnHighPass2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnRed = new DevExpress.XtraEditors.SimpleButton();
            this.btnBlue = new DevExpress.XtraEditors.SimpleButton();
            this.btnGreen = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 35);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Invert";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnEmboss
            // 
            this.btnEmboss.Location = new System.Drawing.Point(12, 58);
            this.btnEmboss.Name = "btnEmboss";
            this.btnEmboss.Size = new System.Drawing.Size(75, 23);
            this.btnEmboss.TabIndex = 3;
            this.btnEmboss.Text = "Emboss";
            this.btnEmboss.Click += new System.EventHandler(this.btnEmboss_Click);
            // 
            // btnEmboss2
            // 
            this.btnEmboss2.Location = new System.Drawing.Point(12, 81);
            this.btnEmboss2.Name = "btnEmboss2";
            this.btnEmboss2.Size = new System.Drawing.Size(75, 23);
            this.btnEmboss2.TabIndex = 4;
            this.btnEmboss2.Text = "Emboss 2";
            this.btnEmboss2.Click += new System.EventHandler(this.btnEmboss2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHighPass1
            // 
            this.btnHighPass1.Location = new System.Drawing.Point(12, 104);
            this.btnHighPass1.Name = "btnHighPass1";
            this.btnHighPass1.Size = new System.Drawing.Size(75, 23);
            this.btnHighPass1.TabIndex = 6;
            this.btnHighPass1.Text = "High Pass 1";
            this.btnHighPass1.Click += new System.EventHandler(this.btnHighPass1_Click);
            // 
            // btnHighPass2
            // 
            this.btnHighPass2.Location = new System.Drawing.Point(12, 127);
            this.btnHighPass2.Name = "btnHighPass2";
            this.btnHighPass2.Size = new System.Drawing.Size(75, 23);
            this.btnHighPass2.TabIndex = 7;
            this.btnHighPass2.Text = "High Pass 2";
            this.btnHighPass2.Click += new System.EventHandler(this.btnHighPass2_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(12, 150);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 8;
            this.btnRed.Text = "Red";
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(12, 173);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBlue.TabIndex = 9;
            this.btnBlue.Text = "Blue";
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(12, 196);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(75, 23);
            this.btnGreen.TabIndex = 10;
            this.btnGreen.Text = "Green";
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // XRayEditMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 568);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnHighPass2);
            this.Controls.Add(this.btnHighPass1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEmboss2);
            this.Controls.Add(this.btnEmboss);
            this.Controls.Add(this.simpleButton1);
            this.IsMdiContainer = true;
            this.Name = "XRayEditMain";
            this.Text = "XRayEdit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnEmboss;
        private DevExpress.XtraEditors.SimpleButton btnEmboss2;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnHighPass1;
        private DevExpress.XtraEditors.SimpleButton btnHighPass2;
        private DevExpress.XtraEditors.SimpleButton btnRed;
        private DevExpress.XtraEditors.SimpleButton btnBlue;
        private DevExpress.XtraEditors.SimpleButton btnGreen;


    }
}