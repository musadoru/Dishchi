using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BlueMax.Classes;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using BlueMax.DAL;
using DevExpress.XtraSplashScreen;


namespace BlueMax
{
    public partial class RvgForm : DevExpress.XtraEditors.XtraForm
    {
        //
        DbContext db = new DbContext();

        Bitmap orgImage;
        Bitmap defImage;

        private int hastaID = -1;
        private string imgSavePath = Application.StartupPath + "\\" + "img" + "\\";
        private string dummyPath = Application.StartupPath + "\\" + "dummy" + "\\";
        private string calibPath = Application.StartupPath + "\\" + "CalibrationFiles" + "\\";

        public RvgForm(int pid)
        {
            InitializeComponent();
            hastaID = pid;
        }

        private void RvgForm_Load(object sender, EventArgs e)
        {
            trackBarBrightness.EditValue = 0;
        }


        EnumManager.TRI_tCaptureReq tRITCaptureReq;

        private void ImagesWait()
        {
            unsafe
            {
                // çekim modu

                //tRITCaptureReq = EnumManager.TRI_tCaptureReq.TRI_CAPTURE_INTEGRATION;
                tRITCaptureReq = EnumManager.TRI_tCaptureReq.TRI_CAPTURE_XRAY;

                External.theImageBufSize[0] = External.TRI_GetImageSize(External.theHandle);
                byte[] numArray = new byte[External.theImageBufSize[0]];
                short[] int16Array = new short[External.theNumLines[0] * External.theLineLength[0]];
                IntPtr intPtr = Marshal.UnsafeAddrOfPinnedArrayElement(numArray, 0);
                IntPtr intPtr1 = Marshal.UnsafeAddrOfPinnedArrayElement(External.theImageBufSize, 0);
                IntPtr intPtr2 = Marshal.UnsafeAddrOfPinnedArrayElement(External.theTimeOut, 0);
                IntPtr intPtr3 = Marshal.UnsafeAddrOfPinnedArrayElement(int16Array, 0);

                if (numArray != null)
                {
                    External.TRI_Capture(External.theHandle, tRITCaptureReq);
                    External.theStatus = External.TRI_AcquireImage_Ori(External.theHandle, numArray, intPtr1, intPtr2);

                    if (External.theStatus != 0)
                    {
                        //görüntü alınamadı. Image aquisition failed
                        int result = External.theStatus;
                        XtraMessageBox.Show("Image aquisition failed [ " + result.ToString() + " ]", "HATA ! 01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // görüntü alındı
                        SplashScreenManager.ShowForm(this, typeof(WaitFormImage), true, true, false);
                        try
                        {

                            string recImageName = DateTime.Now.ToString("yyyyMMddHHmmss");

                            string str = "default";
                            str = string.Concat(dummyPath, str);

                            string deviceSN = Encoding.Default.GetString(External.theCurrentSN).Substring(0, 8);
                            string str2 = string.Concat(calibPath, deviceSN, "_Offset Image");
                            string str3 = string.Concat(calibPath, deviceSN, "_Gain Image");
                            string str4 = string.Concat(calibPath, deviceSN, "_Pixel Map");

                            int int32 = External.TRI_GetTrueImageBuffer(
                                intPtr3,
                                intPtr,
                                External.theImageBufSize[0],
                                Convert.ToUInt32((int)(External.theNumLines[0] * External.theLineLength[0]))
                                );

                            if ((ulong)int32 != (ulong)Convert.ToUInt32((int)(External.theNumLines[0] * External.theLineLength[0])))
                            {
                                string _error = string.Concat("Fail to get the true data buffer - ", int32.ToString());

                                MessageBox.Show(_error, "HATA ! 02");
                            }
                            else
                            {
                                External.TRI_DoCorrections(intPtr3, str2, str3, str4, External.theLineLength[0], External.theNumLines[0], 4);

                                for (int i = 0; i < External.theNumLines[0] * External.theLineLength[0]; i++)
                                {
                                    if (int16Array[i] < 0)
                                    {
                                        int16Array[i] = 0;
                                    }
                                }

                                str = string.Concat(str, ".tiff");
                                External.TRI_WriteBufferInTiff(str, intPtr3, External.theNumLines[0], External.theLineLength[0]);

                                using (Image image = TiffManager.Convert16BitTo8Bit.Run(str))
                                {
                                    if (image != null)
                                    {
                                        pbCapture.Image = image.Clone() as Image;

                                        // ilk görüntü
                                        orgImage = image.Clone() as Bitmap;
                                        defImage = image.Clone() as Bitmap;

                                        try
                                        {
                                            recImageName = string.Concat(recImageName, "_", hastaID.ToString());
                                            recImageName = string.Concat(recImageName, ".tiff");

                                            string recDate = System.DateTime.Now.ToString();
                                            int record = db.Cmd("Insert Into Goruntu(hastaID, imageName, tarih, imgType) Values('" + hastaID + "', '" + recImageName + "', '" + recDate + "', '" + 1 + "')");

                                            string sac = string.Concat(imgSavePath, recImageName);
                                            SaveAndConvert((Bitmap)image.Clone(), 1441, 2148, 80, sac);

                                        }
                                        catch (Exception ex)
                                        {
                                            XtraMessageBox.Show(ex.Message, "HATA! 03", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                        // görüntüleri yenile
                                        ImagesForm imgRefresh = (ImagesForm)System.Windows.Forms.Application.OpenForms["ImagesForm"];
                                        imgRefresh.PatientImageRecords(hastaID);

                                    }
                                    else
                                    {
                                        pbCapture.Image = null;
                                        MessageBox.Show("image null");
                                    }
                                }

                            }
                        }
                        finally
                        {
                            SplashScreenManager.CloseForm(false);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Görüntü Alınamadı ...", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            


        /// <summary>
        /// Method to resize, convert and save the image.
        /// </summary>
        /// <param name="image">Bitmap image.</param>
        /// <param name="maxWidth">resize width.</param>
        /// <param name="maxHeight">resize height.</param>
        /// <param name="quality">quality setting value.</param>
        /// <param name="filePath">file path.</param>  
        public void SaveAndConvert(Bitmap image, int maxWidth, int maxHeight, int quality, string filePath)
        {
            // Get the image's original width and height
            int originalWidth = image.Width;
            int originalHeight = image.Height;

            // To preserve the aspect ratio
            float ratioX = (float)maxWidth / (float)originalWidth;
            float ratioY = (float)maxHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            // New width and height based on aspect ratio
            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            // Convert other formats (including CMYK) to RGB.
            Bitmap newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);

            // Draws the image in the specified size with quality mode set to HighQuality
            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            // Get an ImageCodecInfo object that represents the JPEG codec.
            ImageCodecInfo imageCodecInfo = this.GetEncoderInfo(ImageFormat.Jpeg);

            // Create an Encoder object for the Quality parameter.
            System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object. 
            EncoderParameters encoderParameters = new EncoderParameters(1);

            // Save the image as a JPEG file with quality level.
            EncoderParameter encoderParameter = new EncoderParameter(encoder, quality);
            encoderParameters.Param[0] = encoderParameter;
            newImage.Save(filePath, imageCodecInfo, encoderParameters);
        }

        /// <summary>
        /// Method to get encoder infor for given image format.
        /// </summary>
        /// <param name="format">Image format</param>
        /// <returns>image codec info.</returns>
        private ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().SingleOrDefault(c => c.FormatID == format.Guid);
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            if (pbCapture.Image != null)
            {
                pbCapture.Image = ImageOperations.DoksanDereceSagaDondur(pbCapture.Image);
                //orgImage = (Bitmap)ImageOperations.DoksanDereceSagaDondur((Bitmap)orgImage.Clone());
            }
        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            if (pbCapture.Image != null)
            {
                pbCapture.Image = ImageOperations.DoksanDereceSolaDondur(pbCapture.Image);
                //orgImage = (Bitmap)ImageOperations.DoksanDereceSolaDondur((Bitmap)orgImage.Clone());
            }
        }

        private void btnRotateVertical_Click(object sender, EventArgs e)
        {
            if (pbCapture.Image != null)
            {
                pbCapture.Image = ImageOperations.YatayCevir(pbCapture.Image);
                //orgImage = (Bitmap)ImageOperations.YatayCevir((Bitmap)orgImage.Clone());
            }
        }

        private void btnRotateHorizontal_Click(object sender, EventArgs e)
        {
            if (pbCapture.Image != null)
            {
                pbCapture.Image = ImageOperations.DikeyCevir(pbCapture.Image);
                //orgImage = (Bitmap)ImageOperations.DikeyCevir((Bitmap)orgImage.Clone());
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (pbCapture.Image != null)
            {
                pbCapture.Image = TiffManager.Convert16BitTo8Bit.Transform((Bitmap)pbCapture.Image);
                    //TiffManager.Convert16BitTo8Bit.SetInvert(pbCapture.Image);  
                    //ImageOperations.Negatif((Bitmap)orgImage.Clone());
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            if (defImage != null)
            {
                trackBarBrightness.EditValue = 0;

                pbCapture.Image = null;
                pbCapture.Image = defImage.Clone() as Bitmap;
            }
        }

        private void trackBarBrightness_EditValueChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(trackBarBrightness.EditValue);
            lblBrightness.Text = value.ToString();

            if (pbCapture.Image != null)
            {
                pbCapture.Image = ImageOperations.Contrast((Bitmap)defImage.Clone(), value);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (pbCapture.Image != null)
            {
                pbCapture.Image = null;
            }
            
            ImagesWait();
        }

        //////////
        // Apply a filter.

        private void ApplyFilter(Bitmap32.Filter filter)
        {

            Bitmap bm = pbCapture.Image as Bitmap;
            this.Cursor = Cursors.WaitCursor;
            DateTime start_time = DateTime.Now;

            // Make a Bitmap24 object.
            Bitmap32 bm32 = new Bitmap32(bm);

            // Apply the filter.
            Bitmap32 new_bm32 = bm32.ApplyFilter(filter, false);

            // Display the result.
            pbCapture.Image = new_bm32.Bitmap;

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
            Bitmap bm = (Bitmap)pbCapture.Image;
            this.Cursor = Cursors.WaitCursor;
            DateTime start_time = DateTime.Now;

            // Make a Bitmap24 object.
            Bitmap32 bm32 = new Bitmap32(bm);

            // Convert to red.
            bm32.ClearGreen();
            bm32.ClearBlue();

            // Display the result.
            pbCapture.Image = bm;

            DateTime stop_time = DateTime.Now;
            this.Cursor = Cursors.Default;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            Bitmap bm = (Bitmap)pbCapture.Image;
            this.Cursor = Cursors.WaitCursor;
            DateTime start_time = DateTime.Now;

            // Make a Bitmap24 object.
            Bitmap32 bm32 = new Bitmap32(bm);

            // Convert to blue.
            bm32.ClearRed();
            bm32.ClearGreen();

            // Display the result.
            pbCapture.Image = bm;

            DateTime stop_time = DateTime.Now;
            this.Cursor = Cursors.Default;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            Bitmap bm = (Bitmap)pbCapture.Image;
            this.Cursor = Cursors.WaitCursor;
            DateTime start_time = DateTime.Now;

            // Make a Bitmap24 object.
            Bitmap32 bm32 = new Bitmap32(bm);

            // Convert to green.
            bm32.ClearRed();
            bm32.ClearBlue();

            // Display the result.
            pbCapture.Image = bm;

            DateTime stop_time = DateTime.Now;
            this.Cursor = Cursors.Default;
        }


    }
}