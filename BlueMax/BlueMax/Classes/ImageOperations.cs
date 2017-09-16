using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace BlueMax.Classes
{
    public static class ImageOperations
    {
        public static XRayEdit ImageForm { get; set; }


        public static Image DoksanDereceSagaDondur(Image img)
        {
            if (img != null)
            {
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                return img;
            }
            return null;
        }

        public static Image DoksanDereceSolaDondur(Image img)
        {
            if (img != null)
            {
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                return img;
            }
            return null;
        }

        public static Image DikeyCevir(Image img)
        {
            if (img != null)
            {
                img.RotateFlip(RotateFlipType.Rotate180FlipX);
                return img;
            }
            return null;
        }

        public static Image YatayCevir(Image img)
        {
            if (img != null)
            {
                img.RotateFlip(RotateFlipType.Rotate180FlipY);
                return img;
            }
            return null;
        }

        public static Bitmap Negatif(Bitmap bmp)
        {
            Color c;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    c = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                    bmp.SetPixel(i, j, c);
                }
            }
            return bmp;
        }

        public static Bitmap Contrast(Bitmap sourceBitmap, int threshold)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                        sourceBitmap.Width, sourceBitmap.Height),
                                        ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            double contrastLevel = Math.Pow((100.0 + threshold) / 100.0, 2);

            double blue = 0;
            double green = 0;
            double red = 0;

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                blue = ((((pixelBuffer[k] / 255.0) - 0.5) *
                           contrastLevel) + 0.5) * 255.0;

                green = ((((pixelBuffer[k + 1] / 255.0) - 0.5) *
                            contrastLevel) + 0.5) * 255.0;

                red = ((((pixelBuffer[k + 2] / 255.0) - 0.5) *
                           contrastLevel) + 0.5) * 255.0;

                if (blue > 255)
                { blue = 255; }
                else if (blue < 0)
                { blue = 0; }

                if (green > 255)
                { green = 255; }
                else if (green < 0)
                { green = 0; }

                if (red > 255)
                { red = 255; }
                else if (red < 0)
                { red = 0; }

                pixelBuffer[k] = (byte)blue;
                pixelBuffer[k + 1] = (byte)green;
                pixelBuffer[k + 2] = (byte)red;
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                        resultBitmap.Width, resultBitmap.Height),
                                        ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public static Bitmap AdjustBrightness(Bitmap image, int Value)
        {
            Bitmap TempBitmap = image;

            Bitmap NewBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height);

            Graphics NewGraphics = Graphics.FromImage(NewBitmap);

            float FinalValue = (float)Value / 255.0f;

            float[][] FloatColorMatrix ={
 
                     new float[] {1, 0, 0, 0, 0},
 
                     new float[] {0, 1, 0, 0, 0},
 
                     new float[] {0, 0, 1, 0, 0},
 
                     new float[] {0, 0, 0, 1, 0},
 
                     new float[] {FinalValue, FinalValue, FinalValue, 1, 1}
                 };

            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);

            ImageAttributes Attributes = new ImageAttributes();

            Attributes.SetColorMatrix(NewColorMatrix);

            NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);

            Attributes.Dispose();

            NewGraphics.Dispose();

            return NewBitmap;
        }




       
    }
}
