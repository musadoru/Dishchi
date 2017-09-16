using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AForge.Video.DirectShow;
using AForge.Video;
using BlueMax.DAL;

namespace BlueMax
{
    public partial class CameraForm : DevExpress.XtraEditors.XtraForm
    {
        DbContext db = new DbContext();

        //webcam isminde tanımladığımız değişken bilgisayara kaç kamera bağlıysa onları tutan bir dizi.
        private FilterInfoCollection webcam;

        //cam ise bizim kullanacağımız aygıt.
        private VideoCaptureDevice cam;
        
        private int hastaID = -1;

        string imgPath = Application.StartupPath + "\\" + "img" + "\\";

        // freeze kontrol
        bool islem;

        //kayıt kontrol
        int recordCount = 0;

        public CameraForm(int pid)
        {
            InitializeComponent();
            hastaID = pid;
        }

        private void CameraForm_Load(object sender, EventArgs e)
        {
            try
            {
                //webcam dizisine mevcut kameraları dolduruyoruz.
                webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (webcam.Count >= 1)
                {
                    foreach (FilterInfo videocapturedevice in webcam)
                    {
                        //kameraları combobox a doldur
                        cmbCameraItems.Items.Add(videocapturedevice.Name);
                    }

                    //Kamerayı seç
                    cmbCameraItems.SelectedIndex = 0;

                    //Seçilen kamerayı al
                    cam = new VideoCaptureDevice(webcam[cmbCameraItems.SelectedIndex].MonikerString);
                    cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);

                    //kamerayı başlat
                    cam.Start();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //cam.DesiredFrameSize = new Size(pictureBox1.Width, pictureBox1.Height);
            //cam.DesiredFrameRate = 24;
            //cam.DesiredFrameSize = new Size(640, 480);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            if (cam.IsRunning)
            {
                cam.Stop();
                cam.SignalToStop();
            }

            if (recordCount > 0)
            {
                // görüntüleri yenile
                ImagesForm imgRefresh = (ImagesForm)System.Windows.Forms.Application.OpenForms["ImagesForm"];

                imgRefresh.PatientImageRecords(hastaID);
            }

            this.Close();
        }

        private void btnCameraStart_Click(object sender, EventArgs e)
        {
            //başlaya basıldığıdnda yukarda tanımladığımız cam değişkenine comboboxta seçilmş olan kamerayı atıyoruz.
            cam = new VideoCaptureDevice(webcam[cmbCameraItems.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);

            //kamerayı başlatıyoruz.
            cam.Start();
        }

        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //kısaca bu eventta kameradan alınan görüntüyü picturebox a atıyoruz.
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pbCameraLive.Image = bit;
        }

        private void btnCameraStop_Click(object sender, EventArgs e)
        {
            if (cam.IsRunning)
            {
                cam.Stop();
                cam.SignalToStop();
            }
        }

        private void btnCameraFreeze_Click(object sender, EventArgs e)
        {
            if (islem == false)
            {
                if (cam.IsRunning)
                {
                    //pbDummy.Image = pbCameraLive.Image.Clone() as Bitmap;

                    cam.Stop();
                    cam.SignalToStop();
                    btnCameraFreeze.Text = "Vazgeç";
                    islem = true;
                }
                else
                {
                    //pbDummy.Image = pbCameraLive.Image.Clone() as Bitmap;

                    btnCameraFreeze.Text = "Vazgeç";
                    islem = true;
                }
            }
            else
            {
                if (!cam.IsRunning)
                {
                    cam.Start();
                    btnCameraFreeze.Text = "Yakala";
                    islem = false;
                }
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            try
            {
                string imgName = DateTime.Now.ToString("yyyyMMddHHmmss");
                imgName = string.Concat(imgName, "_", hastaID.ToString());

                DateTime recDate = DateTime.Now.Date;

                if (islem == false)
                {
                    XtraMessageBox.Show("Önce yakala butonuna basınız, ardından kaydet butonuna basabilirsiniz.");
                }
                else
                {
                    using (Image current = pbCameraLive.Image.Clone() as Image) //pbDummy.Image.Clone() as Image)
                    {
                        imgName = imgName + ".jpg";
                        string fileName = System.IO.Path.Combine(imgPath, imgName);
                        current.Save(fileName);
                        current.Dispose();

                        // resim çekildi
                        recordCount++;

                        //Database Kayıt
                        int record = db.Cmd("Insert Into Goruntu(hastaID, imageName, tarih, imgType) Values('" + hastaID + "', '" + imgName + "', '" + recDate + "', '" + 2 + "')");
                    }

                    if (!cam.IsRunning)
                    {
                        cam.Start();
                        btnCameraFreeze.Text = "Yakala";
                        islem = false;
                    }
                }
            }
            catch (Exception exp)
            {
                XtraMessageBox.Show(exp.Message,"HATA !", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }


    }
}