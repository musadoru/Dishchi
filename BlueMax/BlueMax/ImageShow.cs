using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace BlueMax
{
    public partial class ImageShow : DevExpress.XtraEditors.XtraForm
    {
        public ImageShow(string ImagePath)
        {
            InitializeComponent();

            using (FileStream fs = new FileStream(ImagePath, FileMode.Open, FileAccess.Read))
            {
                pbShowImage.Image = Image.FromStream(fs).Clone() as Image;
            }
        }
    }
}