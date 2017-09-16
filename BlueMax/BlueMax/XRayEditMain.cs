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
    public partial class XRayEditMain : DevExpress.XtraEditors.XtraForm
    {
        public XRayEditMain()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                PictureBox mypic = ((XRayEdit)activeChild).picbox;

                mypic.Image = TiffManager.Convert16BitTo8Bit.Transform((Bitmap)mypic.Image);
            }
        }



        //////////
        // Apply a filter.

        PictureBox picVisible;

        private void ApplyFilter(Bitmap32.Filter filter)
        {
            picVisible = new PictureBox();

            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                picVisible = ((XRayEdit)activeChild).picbox;
            }

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

        private void btnEmboss_Click(object sender, EventArgs e)
        {
            ApplyFilter(Bitmap32.EmbossingFilter);
        }

        private void btnEmboss2_Click(object sender, EventArgs e)
        {
            ApplyFilter(Bitmap32.EmbossingFilter2);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                Image defImage = ((XRayEdit)activeChild).OriginalImage;
                PictureBox mypic = ((XRayEdit)activeChild).picbox;

                mypic.Image = defImage;
            }
        }

        private void btnHighPass1_Click(object sender, EventArgs e)
        {
            ApplyFilter(Bitmap32.HighPassFilter3x3);
        }

        private void btnHighPass2_Click(object sender, EventArgs e)
        {
            ApplyFilter(Bitmap32.HighPassFilter5x5);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
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

        private void btnBlue_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
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

        private void btnGreen_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
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
    }
}