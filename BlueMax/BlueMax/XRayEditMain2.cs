using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BlueMax.Classes;

namespace BlueMax
{
    public partial class XRayEditMain2 : DevExpress.XtraEditors.XtraForm
    {
        public XRayEditMain2()
        {
            InitializeComponent();
        }

        private void ToolbarDeneme_Load(object sender, EventArgs e)
        {

        }
        
        PictureBox picVisible;

        private void ApplyFilter(Bitmap32.Filter filter)
        {
            picVisible = new PictureBox();

            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                _TrackBarKontrol(activeChild);

                picVisible = ((XRayEdit)activeChild).picbox;

                Bitmap bm = new Bitmap(picVisible.Image);
                this.Cursor = Cursors.WaitCursor;
                DateTime start_time = DateTime.Now;

                // Make a Bitmap24 object.
                Bitmap32 bm32 = new Bitmap32(bm);

                // Apply the filter.
                Bitmap32 new_bm32 = bm32.ApplyFilter(filter, false);

                // Display the result.
                picVisible.Image = new_bm32.Bitmap;

                DateTime stop_time = DateTime.Now;
                this.Cursor = Cursors.Default;

                //TimeSpan elapsed_time = stop_time - start_time;
                //lblElapsed.Text = elapsed_time.TotalSeconds.ToString("0.000000");
            }
        }


        private void barBtnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;

            if (activeChild != null)
            {
                TrackBarControl trackBarContrast = ((XRayEdit)activeChild).trkBarContrast;
                TrackBarControl trackBarBrightness = ((XRayEdit)activeChild).trkBarBrightness;
                trackBarBrightness.EditValue = 0;
                trackBarContrast.EditValue = 0;

                Image defImage = ((XRayEdit)activeChild).OriginalImage;
                PictureBox mypic = ((XRayEdit)activeChild).picbox;

                mypic.Image = defImage;
            }
        }

        private void barBtnInvert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                _TrackBarKontrol(activeChild);

                PictureBox mypic = ((XRayEdit)activeChild).picbox;

                mypic.Image = TiffManager.Convert16BitTo8Bit.Transform((Bitmap)mypic.Image);
            }
        }

        private void barBtnEmboss_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ApplyFilter(Bitmap32.EmbossingFilter);
            //ApplyFilter(Bitmap32.EmbossingFilter2);
        }

        void _TrackBarKontrol(Form activeChild)
        {
            TrackBarControl trackBarContrast = ((XRayEdit)activeChild).trkBarContrast;
            TrackBarControl trackBarBrightness = ((XRayEdit)activeChild).trkBarBrightness;

            if (trackBarContrast.Visible == true)
            {
                trackBarContrast.Visible = false;
            }
            if (trackBarBrightness.Visible == true)
            {
                trackBarBrightness.Visible = false;
            }
        }

        private void barBtnBrightness_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;

            if (activeChild != null)
            {

                TrackBarControl trackBarBrightness = ((XRayEdit)activeChild).trkBarBrightness;
                TrackBarControl trackBarContrast = ((XRayEdit)activeChild).trkBarContrast;

                if (trackBarBrightness.Visible == true)
                {
                    trackBarBrightness.Visible = false;
                }
                else
                {
                    trackBarBrightness.Visible = true;

                    if (trackBarContrast.Visible == true)
                    {
                        trackBarContrast.Visible = false;
                    }
                }

            }
        }

        private void barBtnContrast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;

            if (activeChild != null)
            {

                TrackBarControl trackBarContrast = ((XRayEdit)activeChild).trkBarContrast;
                TrackBarControl trackBarBrightness = ((XRayEdit)activeChild).trkBarBrightness;

                if (trackBarContrast.Visible == true)
                {
                    trackBarContrast.Visible = false;
                }
                else
                {
                    trackBarContrast.Visible = true;

                    if (trackBarBrightness.Visible == true)
                    {
                        trackBarBrightness.Visible = false;
                    }
                }

            }
        }

        private void barBtnRed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             Form activeChild = this.ActiveMdiChild;
             if (activeChild != null)
             {
                 _TrackBarKontrol(activeChild);

                 PictureBox mypic = ((XRayEdit)activeChild).picbox;

                 Bitmap bm = new Bitmap(mypic.Image);
                 this.Cursor = Cursors.WaitCursor;
                 DateTime start_time = DateTime.Now;

                 // Make a Bitmap24 object.
                 Bitmap32 bm32 = new Bitmap32(bm);

                 // Convert to red.
                 bm32.ClearGreen();
                 bm32.ClearBlue();

                 // Display the result.
                 mypic.Image = bm;

                 DateTime stop_time = DateTime.Now;
                 this.Cursor = Cursors.Default;
             }
        }

        private void barBtnGreen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                _TrackBarKontrol(activeChild);

                PictureBox mypic = ((XRayEdit)activeChild).picbox;

                Bitmap bm = new Bitmap(mypic.Image);
                this.Cursor = Cursors.WaitCursor;
                DateTime start_time = DateTime.Now;

                // Make a Bitmap24 object.
                Bitmap32 bm32 = new Bitmap32(bm);

                // Convert to green.
                bm32.ClearRed();
                bm32.ClearBlue();

                // Display the result.
                mypic.Image = bm;

                DateTime stop_time = DateTime.Now;
                this.Cursor = Cursors.Default;
            }
        }

        private void barBtnBlue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                _TrackBarKontrol(activeChild);

                PictureBox mypic = ((XRayEdit)activeChild).picbox;

                Bitmap bm = new Bitmap(mypic.Image);
                this.Cursor = Cursors.WaitCursor;
                DateTime start_time = DateTime.Now;

                // Make a Bitmap24 object.
                Bitmap32 bm32 = new Bitmap32(bm);

                // Convert to blue.
                bm32.ClearRed();
                bm32.ClearGreen();

                // Display the result.
                mypic.Image = bm;

                DateTime stop_time = DateTime.Now;
                this.Cursor = Cursors.Default;
            }
        }

        private void barBtnRotRight_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                PictureBox mypic = ((XRayEdit)activeChild).picbox;

                mypic.Image = ImageOperations.DoksanDereceSagaDondur(mypic.Image);
            }
        }

        private void barBtnRotLeft_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                PictureBox mypic = ((XRayEdit)activeChild).picbox;

                mypic.Image = ImageOperations.DoksanDereceSolaDondur(mypic.Image);
            }
        }

        private void barBtnRotVertical_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                PictureBox mypic = ((XRayEdit)activeChild).picbox;

                mypic.Image = ImageOperations.DikeyCevir(mypic.Image);
            }
        }

        private void barBtnRotHorizontal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                PictureBox mypic = ((XRayEdit)activeChild).picbox;

                mypic.Image = ImageOperations.YatayCevir(mypic.Image);
            }
        }

        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}