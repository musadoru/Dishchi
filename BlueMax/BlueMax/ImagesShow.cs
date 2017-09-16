using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using System.IO;

namespace BlueMax
{
    public partial class ImagesShow : DevExpress.XtraEditors.XtraForm
    {
        public ImagesShow(List<GalleryItem> resimler)
        {
            InitializeComponent();

            GalleryItemGroup grResimler = new GalleryItemGroup();
            grResimler.Caption = "Görüntü Karşılaştırma";
            galleryControl1.Gallery.Groups.Add(grResimler);

            grResimler.Items.Clear();

            if (resimler.Count <= 2)
            {
                galleryControl1.Gallery.ImageSize = new Size(640, 480);
                galleryControl1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            }
            if (resimler.Count > 2)
            {
                galleryControl1.Gallery.ImageSize = new Size(314, 235);
                galleryControl1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            }

            for (int i = 0; i < resimler.Count; i++)
            {
                using (FileStream fs = new FileStream(resimler[i].Description, FileMode.Open, FileAccess.Read))
                {
                    Image image = Image.FromStream(fs);
                    grResimler.Items.Add(new GalleryItem(image.Clone() as Image, "", resimler[i].Description));

                }
            }

        }
    }
}