using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BlueMax.DAL;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Ribbon;
using System.IO;
using BlueMax.Classes;

namespace BlueMax
{
    public partial class ImagesForm : DevExpress.XtraEditors.XtraForm
    {
        DbContext db = new DbContext();

        List<Images> imgList = new List<Images>();

        int patientID = -1;

        string val = BTCore.EncryptToBase64(External.btkNS);

        string imgPath = Application.StartupPath + "\\" + "img" + "\\";

        //private int activePatientID;

        public ImagesForm()
        {
            InitializeComponent();
            PatientRecords();
        }

        private void ImagesForm_Load(object sender, EventArgs e)
        {
            lblHasta.Text = "Lütfen Hasta Seçiniz";

            gallContRvg.Gallery.ImageSize = new Size(trackBarGalleryImages.Value, trackBarGalleryImages.Value);
        }

        public void PatientRecords()
        {
            try
            {
                var hastaData = db.GetDataTable("Select * From Hasta");

                List<Hasta> hastalar = new List<Hasta>();
                hastalar.Clear();

                foreach (DataRow dtRow in hastaData.Rows)
                {
                    Hasta hasta = new Hasta();
                    hasta.ID = Convert.ToInt32(dtRow["ID"].ToString());
                    hasta.isim = dtRow["isim"].ToString() + " " + dtRow["soyisim"].ToString();
                    hastalar.Add(hasta);
                }

                lookUpHasta.Properties.NullText = "[Hasta Seçiniz]";
                lookUpHasta.Properties.SearchMode = SearchMode.AutoComplete;
                lookUpHasta.Properties.DataSource = hastalar;
                lookUpHasta.Properties.DisplayMember = "isim";
                lookUpHasta.Properties.ValueMember = "ID";
                LookUpColumnInfoCollection coll = lookUpHasta.Properties.Columns;
                coll.Add(new LookUpColumnInfo("isim", 0, "Kayıtlı Hastalar"));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBarGalleryImages_EditValueChanged(object sender, EventArgs e)
        {
            gallContRvg.Gallery.ImageSize = new Size(trackBarGalleryImages.Value, trackBarGalleryImages.Value);
        }

        private void lookUpHasta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;
                gallContRvg.Gallery.Groups.Clear();

                patientID = Convert.ToInt32(lookUpHasta.EditValue.ToString());
                string Isim = lookUpHasta.Text;

                lblHasta.Text = Isim;

                //activePatientID = patientID;

                PatientImageRecords(patientID);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnNewRvg.Focus();
            }
        }

        public void PatientImageRecords(int id)
        {
            try
            {
                var hastaImg = db.GetDataTable("Select * From Goruntu Where hastaID=" + id + " Order By ID Desc");

                imgList.Clear();

                foreach (DataRow dtRow in hastaImg.Rows)
                {
                    // images classes, not .net image
                    Images img = new Images();
                    img.Id = Convert.ToInt32(dtRow["ID"].ToString());
                    img.ImgName = dtRow["imageName"].ToString();
                    img.ImgDate = dtRow["tarih"].ToString();
                    img.PatientID = id;
                    img.ImgType = Convert.ToInt32(dtRow["imgType"]);
                    imgList.Add(img);
                }

                if (imgList.Count <= 0)
                {
                    lblError.Visible = true;
                    lblError.Text = "Seçilen hastaya ait Görüntü kaydı bulunamadı !";
                }
                else
                {
                    lblError.Visible = false;
                    lblError.Text = "";
                    PatientImageData(imgList);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PatientImageData(List<Images> imgList)
        {
            gallContRvg.Gallery.Groups.Clear();

            GalleryItemGroup groupRvg = new GalleryItemGroup();
            groupRvg.Caption = "RVG Görüntüleri";
            gallContRvg.Gallery.Groups.Add(groupRvg);

            GalleryItemGroup groupCamera = new GalleryItemGroup();
            groupCamera.Caption = "Kamera Görüntüleri";
            gallContRvg.Gallery.Groups.Add(groupCamera);

            for (int i = 0; i < imgList.Count; i++)
            {
                if (System.IO.File.Exists(Path.Combine(imgPath, imgList[i].ImgName))) //db de kayıtlı dosyayı gerekli dizinde bulabilirsen ekle
                {
                    using (FileStream fs = new FileStream(Path.Combine(imgPath, imgList[i].ImgName), FileMode.Open))
                    {
                        Image image = Image.FromStream(fs);
                        Image image2 = image.Clone() as Image;
                        image2.Tag = imgList[i].Id;

                        if (imgList[i].ImgType == 1)
                        {
                            gallContRvg.Gallery.Groups[0].Items.Add(new GalleryItem(image2, imgList[i].ImgDate, Path.Combine(imgPath + imgList[i].ImgName)));
                        }
                        if (imgList[i].ImgType == 2)
                        {
                            gallContRvg.Gallery.Groups[1].Items.Add(new GalleryItem(image2, imgList[i].ImgDate, Path.Combine(imgPath + imgList[i].ImgName)));
                        }
                    }
                }
            }

            #region galleryGorupsVisible
            // rvg görüntüsü yoksa, grubu gizle
            if (groupRvg.Items.Count <= 0)
            {
                gallContRvg.Gallery.Groups[0].Visible = false;
            }
            // kamera görüntüsü yoksa, grubu gizle
            if (groupCamera.Items.Count <= 0)
            {
                gallContRvg.Gallery.Groups[1].Visible = false;
            }
            #endregion galleryGorupsVisible

        }

        public void ImageDataRefresh(int id)
        {
            if (id == patientID)
            {
                PatientImageRecords(id);
            }
        }

        private void btnNewRvg_Click(object sender, EventArgs e)
        {
            if (val == External.bek)
            {
                if (patientID == -1)
                {
                    XtraMessageBox.Show("Lütfen önce Hasta seçiniz..", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (External.sensorConnection)
                    {
                        using (RvgForm rvg = new RvgForm(patientID))
                        {
                            rvg.ShowDialog();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Sensör Bulunamadı", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Uygun sensörü takıp yeniden deneyiniz.", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNewCamera_Click(object sender, EventArgs e)
        {
            if (val == External.bek)
            {
                if (patientID == -1)
                {
                    XtraMessageBox.Show("Lütfen önce Hasta seçiniz..", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (CameraForm cam = new CameraForm(patientID))
                    {
                        cam.ShowDialog();
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Uygun sensörü takıp yeniden deneyiniz.", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            using (PatientForm patient = new PatientForm(true))
            {
                patient.ShowDialog();
            }
        }

        private void galleryControlGallery1_ItemDoubleClick(object sender, GalleryItemClickEventArgs e)
        {
            string itemPath = e.Item.Description;

            using (ImageShow imgShow = new ImageShow(itemPath))
            {
                imgShow.ShowDialog();
            }
        }

        private void btnShowImages_Click(object sender, EventArgs e)
        {
            List<GalleryItem> secilen = new List<GalleryItem>();

            secilen.AddRange(gallContRvg.Gallery.Groups[0].GetCheckedItems());
            secilen.AddRange(gallContRvg.Gallery.Groups[1].GetCheckedItems());

            if (secilen.Count > 0)
            {
                using (ImagesShow toplu = new ImagesShow(secilen))
                {
                    toplu.ShowDialog();
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen bir veya birden fazla resim seçiniz.", "UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveImages_Click(object sender, EventArgs e)
        {
            List<GalleryItem> secSil = new List<GalleryItem>();

            secSil.AddRange(gallContRvg.Gallery.Groups[0].GetCheckedItems());
            secSil.AddRange(gallContRvg.Gallery.Groups[1].GetCheckedItems());

            if (secSil.Count > 0)
            {
                DialogResult dialog;
                dialog = XtraMessageBox.Show("Seçtiğiniz Görüntüler kalıcı olarak silinecektir. Onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        foreach (var item in secSil)
                        {
                            // önce db den sil
                            int imgID = Convert.ToInt32(item.Image.Tag);
                            var imgRemove = db.Cmd("DELETE From Goruntu Where ID=" + imgID + "");

                            foreach (GalleryItemGroup gal in gallContRvg.Gallery.Groups)
                            {
                                bool found = false;

                                foreach (GalleryItem galItem in gal.Items)
                                {
                                    if (galItem == item)
                                    {
                                        found = true;
                                    }
                                }//for gallery group gallery item

                                if (found)
                                {
                                    item.Image = null;
                                    File.Delete(item.Description);
                                    gal.Items.Remove(item);
                                    break;
                                }
                            }//for gallery group

                        }//for list gallery item
                    }
                    catch (Exception exp)
                    {
                        XtraMessageBox.Show(exp.Message, "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // resimleri yenile
                    PatientImageRecords(patientID);

                }// Dialog Result
            }
            else
            {
                XtraMessageBox.Show("Silme işlemi için Lütfen bir veya birden fazla resim seçiniz.", "UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRvgEdit_Click(object sender, EventArgs e)
        {
            List<GalleryItem> editList = gallContRvg.Gallery.GetCheckedItems();

            if (editList.Count > 0)
            {
                //using (XRayEditMain duzenle = new XRayEditMain())
                using(XRayEditMain2 duzenle = new XRayEditMain2())
                {
                    for (int i = 0; i < editList.Count; i++)
                    {
                        XRayEdit resim = new XRayEdit();
                        resim.MdiParent = duzenle;
                        resim.Text = "Görüntü No: " + i.ToString();

                        string imgName = editList[i].Description;

                        resim.ResimYukle(imgName);

                        resim.Show();
                    }

                    duzenle.ShowDialog();
                }
            }
        }
    }
}