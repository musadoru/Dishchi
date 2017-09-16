namespace BlueMax
{
    partial class ImagesForm
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
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagesForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnRvgEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemoveImages = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowImages = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewCamera = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewRvg = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewPatient = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.trackBarGalleryImages = new DevExpress.XtraEditors.TrackBarControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lblError = new DevExpress.XtraEditors.LabelControl();
            this.lblHasta = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpHasta = new DevExpress.XtraEditors.LookUpEdit();
            this.gallContRvg = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGalleryImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGalleryImages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallContRvg)).BeginInit();
            this.gallContRvg.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnRvgEdit);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnRemoveImages);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnShowImages);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnNewCamera);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnNewRvg);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnNewPatient);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gallContRvg);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(820, 682);
            this.splitContainerControl1.SplitterPosition = 300;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnRvgEdit
            // 
            this.btnRvgEdit.Location = new System.Drawing.Point(0, 442);
            this.btnRvgEdit.Name = "btnRvgEdit";
            this.btnRvgEdit.Size = new System.Drawing.Size(300, 52);
            this.btnRvgEdit.TabIndex = 10;
            this.btnRvgEdit.Text = "Görüntü Düzenle";
            this.btnRvgEdit.Click += new System.EventHandler(this.btnRvgEdit_Click);
            // 
            // btnRemoveImages
            // 
            this.btnRemoveImages.Location = new System.Drawing.Point(0, 384);
            this.btnRemoveImages.Name = "btnRemoveImages";
            this.btnRemoveImages.Size = new System.Drawing.Size(300, 52);
            this.btnRemoveImages.TabIndex = 9;
            this.btnRemoveImages.Text = "Seçilen Görüntüleri Sil";
            this.btnRemoveImages.Click += new System.EventHandler(this.btnRemoveImages_Click);
            // 
            // btnShowImages
            // 
            this.btnShowImages.Location = new System.Drawing.Point(0, 326);
            this.btnShowImages.Name = "btnShowImages";
            this.btnShowImages.Size = new System.Drawing.Size(300, 52);
            this.btnShowImages.TabIndex = 8;
            this.btnShowImages.Text = "Seçilen Görüntüleri Göster";
            this.btnShowImages.Click += new System.EventHandler(this.btnShowImages_Click);
            // 
            // btnNewCamera
            // 
            this.btnNewCamera.Location = new System.Drawing.Point(0, 268);
            this.btnNewCamera.Name = "btnNewCamera";
            this.btnNewCamera.Size = new System.Drawing.Size(145, 52);
            this.btnNewCamera.TabIndex = 7;
            this.btnNewCamera.Text = "KAMERA";
            this.btnNewCamera.Click += new System.EventHandler(this.btnNewCamera_Click);
            // 
            // btnNewRvg
            // 
            this.btnNewRvg.Location = new System.Drawing.Point(155, 268);
            this.btnNewRvg.Name = "btnNewRvg";
            this.btnNewRvg.Size = new System.Drawing.Size(145, 52);
            this.btnNewRvg.TabIndex = 6;
            this.btnNewRvg.Text = "RVG";
            this.btnNewRvg.Click += new System.EventHandler(this.btnNewRvg_Click);
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.Location = new System.Drawing.Point(0, 210);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(300, 52);
            this.btnNewPatient.TabIndex = 5;
            this.btnNewPatient.Text = "HASTA EKLE";
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.trackBarGalleryImages);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 592);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(300, 90);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Resim Boyutları";
            // 
            // trackBarGalleryImages
            // 
            this.trackBarGalleryImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarGalleryImages.EditValue = 100;
            this.trackBarGalleryImages.Location = new System.Drawing.Point(2, 21);
            this.trackBarGalleryImages.Name = "trackBarGalleryImages";
            this.trackBarGalleryImages.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarGalleryImages.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "80";
            trackBarLabel1.Value = 80;
            trackBarLabel2.Label = "160";
            trackBarLabel2.Value = 160;
            trackBarLabel3.Label = "240";
            trackBarLabel3.Value = 240;
            this.trackBarGalleryImages.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2,
            trackBarLabel3});
            this.trackBarGalleryImages.Properties.Maximum = 480;
            this.trackBarGalleryImages.Properties.Minimum = 80;
            this.trackBarGalleryImages.Properties.ShowLabels = true;
            this.trackBarGalleryImages.Size = new System.Drawing.Size(296, 67);
            this.trackBarGalleryImages.TabIndex = 0;
            this.trackBarGalleryImages.Value = 100;
            this.trackBarGalleryImages.EditValueChanged += new System.EventHandler(this.trackBarGalleryImages_EditValueChanged);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lblError);
            this.groupControl3.Controls.Add(this.lblHasta);
            this.groupControl3.Location = new System.Drawing.Point(0, 91);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(300, 113);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "İşlem Yapılan Hasta";
            // 
            // lblError
            // 
            this.lblError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(13, 68);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(34, 13);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "lblError";
            this.lblError.Visible = false;
            // 
            // lblHasta
            // 
            this.lblHasta.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblHasta.Location = new System.Drawing.Point(13, 34);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(62, 18);
            this.lblHasta.TabIndex = 0;
            this.lblHasta.Text = "lblHasta";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lookUpHasta);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(300, 85);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Hasta Ara";
            // 
            // lookUpHasta
            // 
            this.lookUpHasta.Location = new System.Drawing.Point(14, 35);
            this.lookUpHasta.MinimumSize = new System.Drawing.Size(0, 30);
            this.lookUpHasta.Name = "lookUpHasta";
            this.lookUpHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpHasta.Properties.DropDownItemHeight = 30;
            this.lookUpHasta.Properties.PopupFormMinSize = new System.Drawing.Size(0, 30);
            this.lookUpHasta.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.lookUpHasta.Properties.ShowFooter = false;
            this.lookUpHasta.Size = new System.Drawing.Size(272, 30);
            this.lookUpHasta.TabIndex = 3;
            this.lookUpHasta.EditValueChanged += new System.EventHandler(this.lookUpHasta_EditValueChanged);
            // 
            // gallContRvg
            // 
            this.gallContRvg.Controls.Add(this.galleryControlClient1);
            this.gallContRvg.DesignGalleryGroupIndex = 0;
            this.gallContRvg.DesignGalleryItemIndex = 0;
            this.gallContRvg.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // galleryControlGallery1
            // 
            this.gallContRvg.Gallery.ClearSelectionOnClickEmptySpace = true;
            this.gallContRvg.Gallery.ImageSize = new System.Drawing.Size(100, 100);
            this.gallContRvg.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple;
            this.gallContRvg.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.gallContRvg.Gallery.ItemDoubleClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControlGallery1_ItemDoubleClick);
            this.gallContRvg.Location = new System.Drawing.Point(0, 0);
            this.gallContRvg.Name = "gallContRvg";
            this.gallContRvg.Size = new System.Drawing.Size(515, 682);
            this.gallContRvg.TabIndex = 0;
            this.gallContRvg.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.gallContRvg;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(494, 678);
            // 
            // ImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 682);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImagesForm";
            this.ShowIcon = false;
            this.Text = "Hasta Görüntü İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ImagesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGalleryImages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGalleryImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallContRvg)).EndInit();
            this.gallContRvg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TrackBarControl trackBarGalleryImages;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl lblError;
        private DevExpress.XtraEditors.LabelControl lblHasta;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpHasta;
        private DevExpress.XtraBars.Ribbon.GalleryControl gallContRvg;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraEditors.SimpleButton btnNewCamera;
        private DevExpress.XtraEditors.SimpleButton btnNewRvg;
        private DevExpress.XtraEditors.SimpleButton btnNewPatient;
        private DevExpress.XtraEditors.SimpleButton btnShowImages;
        private DevExpress.XtraEditors.SimpleButton btnRemoveImages;
        private DevExpress.XtraEditors.SimpleButton btnRvgEdit;
    }
}