namespace BlueMax
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdHastalar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCins = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcKt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpCinsiyet = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.lblGsm = new DevExpress.XtraEditors.LabelControl();
            this.txtGsm = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.dateDt = new DevExpress.XtraEditors.DateEdit();
            this.lblTc = new DevExpress.XtraEditors.LabelControl();
            this.txtTcKimlik = new DevExpress.XtraEditors.TextEdit();
            this.lblDt = new DevExpress.XtraEditors.LabelControl();
            this.txtSurName = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHastalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCinsiyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGsm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDt.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTcKimlik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grdHastalar);
            this.groupControl2.Location = new System.Drawing.Point(12, 201);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(924, 357);
            this.groupControl2.TabIndex = 130;
            this.groupControl2.Text = "HASTA KAYITLARI";
            // 
            // grdHastalar
            // 
            this.grdHastalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHastalar.Location = new System.Drawing.Point(2, 21);
            this.grdHastalar.MainView = this.gridView1;
            this.grdHastalar.Name = "grdHastalar";
            this.grdHastalar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.grdHastalar.Size = new System.Drawing.Size(920, 334);
            this.grdHastalar.TabIndex = 0;
            this.grdHastalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdHastalar.DoubleClick += new System.EventHandler(this.grdHastalar_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcId,
            this.gcAd,
            this.gcSoyad,
            this.gcTck,
            this.gcDt,
            this.gcCep,
            this.gcCins,
            this.gcKt});
            this.gridView1.GridControl = this.grdHastalar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // gcId
            // 
            this.gcId.Caption = "ID";
            this.gcId.FieldName = "ID";
            this.gcId.Name = "gcId";
            // 
            // gcAd
            // 
            this.gcAd.Caption = "ADI";
            this.gcAd.FieldName = "isim";
            this.gcAd.Name = "gcAd";
            this.gcAd.Visible = true;
            this.gcAd.VisibleIndex = 0;
            // 
            // gcSoyad
            // 
            this.gcSoyad.Caption = "SOYADI";
            this.gcSoyad.FieldName = "soyisim";
            this.gcSoyad.Name = "gcSoyad";
            this.gcSoyad.Visible = true;
            this.gcSoyad.VisibleIndex = 1;
            // 
            // gcTck
            // 
            this.gcTck.Caption = "T.C. KİMLİK NO";
            this.gcTck.FieldName = "tcKimlik";
            this.gcTck.Name = "gcTck";
            this.gcTck.Visible = true;
            this.gcTck.VisibleIndex = 2;
            // 
            // gcDt
            // 
            this.gcDt.Caption = "DOĞUM TARİHİ";
            this.gcDt.FieldName = "dt";
            this.gcDt.Name = "gcDt";
            this.gcDt.Visible = true;
            this.gcDt.VisibleIndex = 3;
            // 
            // gcCep
            // 
            this.gcCep.Caption = "CEP TELEFONU";
            this.gcCep.FieldName = "gsm";
            this.gcCep.Name = "gcCep";
            this.gcCep.Visible = true;
            this.gcCep.VisibleIndex = 4;
            // 
            // gcCins
            // 
            this.gcCins.Caption = "CİNSİYET";
            this.gcCins.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.gcCins.FieldName = "cinsiyet";
            this.gcCins.Name = "gcCins";
            this.gcCins.Visible = true;
            this.gcCins.VisibleIndex = 5;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // gcKt
            // 
            this.gcKt.Caption = "KAYIT TARİHİ";
            this.gcKt.FieldName = "kayitTarihi";
            this.gcKt.Name = "gcKt";
            this.gcKt.Visible = true;
            this.gcKt.VisibleIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.lookUpCinsiyet);
            this.groupControl1.Controls.Add(this.lblCinsiyet);
            this.groupControl1.Controls.Add(this.lblGsm);
            this.groupControl1.Controls.Add(this.txtGsm);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.lblAd);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.lblSoyad);
            this.groupControl1.Controls.Add(this.dateDt);
            this.groupControl1.Controls.Add(this.lblTc);
            this.groupControl1.Controls.Add(this.txtTcKimlik);
            this.groupControl1.Controls.Add(this.lblDt);
            this.groupControl1.Controls.Add(this.txtSurName);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(924, 173);
            this.groupControl1.TabIndex = 120;
            this.groupControl1.Text = "HASTA FORMU";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(765, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 49);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.Text = "Vazgeç";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lookUpCinsiyet
            // 
            this.lookUpCinsiyet.Location = new System.Drawing.Point(650, 81);
            this.lookUpCinsiyet.MinimumSize = new System.Drawing.Size(0, 30);
            this.lookUpCinsiyet.Name = "lookUpCinsiyet";
            this.lookUpCinsiyet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCinsiyet.Properties.DropDownItemHeight = 30;
            this.lookUpCinsiyet.Properties.PopupSizeable = false;
            this.lookUpCinsiyet.Properties.ShowFooter = false;
            this.lookUpCinsiyet.Size = new System.Drawing.Size(80, 30);
            this.lookUpCinsiyet.TabIndex = 12;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.Location = new System.Drawing.Point(650, 62);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(38, 13);
            this.lblCinsiyet.TabIndex = 6;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // lblGsm
            // 
            this.lblGsm.Location = new System.Drawing.Point(523, 62);
            this.lblGsm.Name = "lblGsm";
            this.lblGsm.Size = new System.Drawing.Size(64, 13);
            this.lblGsm.TabIndex = 5;
            this.lblGsm.Text = "Cep Telefonu";
            // 
            // txtGsm
            // 
            this.txtGsm.Location = new System.Drawing.Point(523, 81);
            this.txtGsm.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(121, 30);
            this.txtGsm.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(15, 136);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 20);
            this.txtID.TabIndex = 100;
            this.txtID.Visible = false;
            // 
            // lblAd
            // 
            this.lblAd.Location = new System.Drawing.Point(15, 62);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(46, 13);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Hasta Adı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(765, 37);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(142, 49);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblSoyad
            // 
            this.lblSoyad.Location = new System.Drawing.Point(142, 62);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(63, 13);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Hasta Soyadı";
            // 
            // dateDt
            // 
            this.dateDt.EditValue = null;
            this.dateDt.Location = new System.Drawing.Point(396, 81);
            this.dateDt.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateDt.Name = "dateDt";
            this.dateDt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDt.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateDt.Size = new System.Drawing.Size(121, 30);
            this.dateDt.TabIndex = 10;
            // 
            // lblTc
            // 
            this.lblTc.Location = new System.Drawing.Point(269, 62);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(65, 13);
            this.lblTc.TabIndex = 3;
            this.lblTc.Text = "T.C. Kimlik No";
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(269, 81);
            this.txtTcKimlik.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(121, 30);
            this.txtTcKimlik.TabIndex = 9;
            // 
            // lblDt
            // 
            this.lblDt.Location = new System.Drawing.Point(396, 62);
            this.lblDt.Name = "lblDt";
            this.lblDt.Size = new System.Drawing.Size(62, 13);
            this.lblDt.TabIndex = 4;
            this.lblDt.Text = "Doğum Tarihi";
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(142, 81);
            this.txtSurName.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(121, 30);
            this.txtSurName.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 81);
            this.txtName.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 30);
            this.txtName.TabIndex = 7;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 622);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatientForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayıtları";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHastalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCinsiyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGsm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDt.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTcKimlik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grdHastalar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gcId;
        private DevExpress.XtraGrid.Columns.GridColumn gcAd;
        private DevExpress.XtraGrid.Columns.GridColumn gcSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn gcTck;
        private DevExpress.XtraGrid.Columns.GridColumn gcDt;
        private DevExpress.XtraGrid.Columns.GridColumn gcKt;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl lblSoyad;
        private DevExpress.XtraEditors.DateEdit dateDt;
        private DevExpress.XtraEditors.LabelControl lblTc;
        private DevExpress.XtraEditors.TextEdit txtTcKimlik;
        private DevExpress.XtraEditors.LabelControl lblDt;
        private DevExpress.XtraEditors.TextEdit txtSurName;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblGsm;
        private DevExpress.XtraEditors.TextEdit txtGsm;
        private DevExpress.XtraEditors.LabelControl lblCinsiyet;
        private DevExpress.XtraEditors.LookUpEdit lookUpCinsiyet;
        private DevExpress.XtraGrid.Columns.GridColumn gcCep;
        private DevExpress.XtraGrid.Columns.GridColumn gcCins;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}