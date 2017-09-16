using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using BlueMax.Classes;

namespace BlueMax
{
    public partial class XRayEdit : DevExpress.XtraEditors.XtraForm
    {
        public Image OriginalImage { get; set; }

        public XRayEdit()
        {
            InitializeComponent();

            trckBarBrightness.EditValue = 0;
            trckBarBrightness.Dock = DockStyle.Bottom;
            trckBarBrightness.Visible = false;

            trckBarContrast.EditValue = 0;
            trckBarContrast.Dock = DockStyle.Bottom;
            trckBarContrast.Visible = false;
        }

        public void ResimYukle(string resim)
        {
            using (FileStream fs = new FileStream(resim, FileMode.Open, FileAccess.Read))
            {
                OriginalImage = Image.FromStream(fs).Clone() as Image;
                pictureBox1.Image = Image.FromStream(fs).Clone() as Image;
            }
        }

        private void ClearForm()
        {
            if (ImageOperations.ImageForm == this)
            {
                ImageOperations.ImageForm = null;
            }
        }

        private void XRayEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearForm();
        }

        public PictureBox picbox
        {
            get
            {
                return pictureBox1;
            }
            set
            {
                pictureBox1 = value;
            }
        }

        public TrackBarControl trkBarBrightness
        {
            get
            {
                return trckBarBrightness;
            }
            set
            {
                trckBarBrightness = value;
            }
        }

        public TrackBarControl trkBarContrast
        {
            get
            {
                return trckBarContrast;
            }
            set
            {
                trckBarContrast = value;
            }
        }

        private void trckBarBrightness_EditValueChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(trckBarBrightness.EditValue);

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = ImageOperations.AdjustBrightness((Bitmap)OriginalImage, value);
            }
        }

        private void trckBarContrast_EditValueChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(trckBarContrast.EditValue);

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = ImageOperations.Contrast((Bitmap)OriginalImage, value);
            }
        }
    }
}