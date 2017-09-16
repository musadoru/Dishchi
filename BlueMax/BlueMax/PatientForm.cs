using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BlueMax.DAL;
using BlueMax.Classes;
using DevExpress.XtraEditors.Controls;

namespace BlueMax
{
    public partial class PatientForm : DevExpress.XtraEditors.XtraForm
    {
        DbContext data = new DbContext();

        bool editForm;

        bool imageForm;

        public PatientForm(bool? img)
        {
            InitializeComponent();

            if (img.HasValue)
            {
                imageForm = img.Value;
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            // hasta kayıtları
            HastaInit();

            // lookup cinsiyet enum
            GetCinsiyetLookup();
        }

        private void HastaInit()
        {
            grdHastalar.DataSource = null;

            try
            {
                grdHastalar.DataSource = data.GetDataTable("Select ID, isim, soyisim, tcKimlik, dt, gsm, cinsiyet, kayitTarihi From Hasta");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetCinsiyetLookup()
        {
            lookUpCinsiyet.Properties.DataSource = EnumOperations.GetObjects<EnumManager.Cinsiyet>();
            lookUpCinsiyet.Properties.ValueMember = "Id";
            lookUpCinsiyet.Properties.DisplayMember = "Name";

            // gösterilecek kolonu oluştur ve görünümü ayarla
            LookUpColumnInfoCollection lookUpPeriyodColl = lookUpCinsiyet.Properties.Columns;
            lookUpPeriyodColl.Add(new LookUpColumnInfo("Name", 0, "Cinsiyet"));

            // ilk item seçili gelsin
            lookUpCinsiyet.EditValue = lookUpCinsiyet.Properties.GetDataSourceValue(lookUpCinsiyet.Properties.ValueMember, 0);

            // gridview cinsiyet cell Value, display value
            repositoryItemLookUpEdit1.DataSource = EnumOperations.GetObjects<EnumManager.Cinsiyet>();
            repositoryItemLookUpEdit1.ValueMember = "Id";
            repositoryItemLookUpEdit1.DisplayMember = "Name";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (editForm)
            {
                EditHasta();
            }
            else
            {
                YeniHasta();
            }
        }

        private void YeniHasta()
        {
            try
            {
                string name, surname, tc, dt, gsmno;
                DateTime recDate = System.DateTime.Now;
                int cins = Convert.ToInt32(lookUpCinsiyet.EditValue);

                name = txtName.Text;
                surname = txtSurName.Text;
                tc = txtTcKimlik.Text;
                gsmno = txtGsm.Text;

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname))
                {
                    if (dateDt.EditValue != null)
                    {
                        dt = dateDt.SelectedText.ToString();
                    }
                    else
                    {
                        dt = "01.01.2001";
                    }

                    int record = data.Cmd("Insert Into Hasta(isim, soyisim, tcKimlik, dt, gsm, cinsiyet, kayitTarihi) Values('" + name + "', '" + surname + "', '" + tc + "', '" + dt + "', '" + gsmno + "', '" + cins + "', '" + recDate + "')");

                    if (record >= 0)
                    {
                        XtraMessageBox.Show("Hasta kaydı başarıyla yapıldı.", "BİLGİ !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HastaInit();

                        txtName.Text = string.Empty;
                        txtSurName.Text = string.Empty;
                        txtTcKimlik.Text = string.Empty;
                        dateDt.EditValue = null;

                        if (imageForm == true)
                        {
                            ImagesForm imgFormRefresh = (ImagesForm)System.Windows.Forms.Application.OpenForms["ImagesForm"];
                            imgFormRefresh.PatientRecords();
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Kayıt Yapılamadı !\nHasta Adı ve Soyadı yazmadınız.. ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditHasta()
        {
            try
            {
                int hastaID = Convert.ToInt32(txtID.Text);

                string name, surname, tc, dte, gsmno;

                name = txtName.Text;
                surname = txtSurName.Text;
                tc = txtTcKimlik.Text;
                gsmno = txtGsm.Text;
                int cins = Convert.ToInt32(lookUpCinsiyet.EditValue);

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname))
                {
                    if (!string.IsNullOrEmpty(dateDt.Text))
                    {
                        dte = dateDt.Text;
                    }
                    else
                    {
                        dte = "01.01.2001";
                    }

                    string cc = "Update Hasta Set isim='" + name + "', soyisim='" + surname + "', tcKimlik='" + tc + "', dt='" + dte + "', gsm='" + gsmno + "', cinsiyet=" + cins + " Where ID=" + hastaID + "";

                    int record = data.Cmd(cc);

                    if (record >= 0)
                    {
                        XtraMessageBox.Show("Hasta kaydı başarıyla güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HastaInit();

                        txtName.Text = string.Empty;
                        txtSurName.Text = string.Empty;
                        txtTcKimlik.Text = string.Empty;
                        dateDt.EditValue = null;
                        txtGsm.Text = string.Empty;
                        txtID.Text = string.Empty;

                        editForm = false;

                        if (imageForm == true)
                        {
                            ImagesForm imgFormRefresh = (ImagesForm)System.Windows.Forms.Application.OpenForms["ImagesForm"];
                            imgFormRefresh.PatientRecords();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdHastalar_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int hastaID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));

                var item = data.GetDataRow("Select ID, isim, soyisim, tcKimlik, dt, gsm, cinsiyet, kayitTarihi From Hasta Where ID=" + hastaID + "");

                txtName.Text = item["isim"].ToString();
                txtSurName.Text = item["soyisim"].ToString();
                txtTcKimlik.Text = item["tcKimlik"].ToString();
                txtGsm.Text = item["gsm"].ToString();
                txtID.Text = hastaID.ToString();

                if (item["dt"] != null)
                {
                    dateDt.EditValue = item["dt"];
                }

                if (item["cinsiyet"] != null)
                {
                    lookUpCinsiyet.EditValue = item["cinsiyet"];
                }

                editForm = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtSurName.Text = string.Empty;
            txtTcKimlik.Text = string.Empty;
            dateDt.EditValue = null;
            txtGsm.Text = string.Empty;
            txtID.Text = string.Empty;

            editForm = false;
        }
    }
}