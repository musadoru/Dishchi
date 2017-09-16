using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using BitMiracle.LibTiff.Classic;
using System.Drawing.Imaging;


namespace BlueMax.Classes
{
    public class TiffManager
    {
        public static class Convert16BitTo8Bit
        {
            public static Image Run(string imagePath)
            {
                using (Tiff tiff = Tiff.Open(imagePath, "r"))
                {
                    int width = tiff.GetField(TiffTag.IMAGEWIDTH)[0].ToInt();
                    int height = tiff.GetField(TiffTag.IMAGELENGTH)[0].ToInt();
                    double dpiX = tiff.GetField(TiffTag.XRESOLUTION)[0].ToDouble();
                    double dpiY = tiff.GetField(TiffTag.YRESOLUTION)[0].ToDouble();

                    byte[] scanline = new byte[tiff.ScanlineSize()];
                    ushort[] scanline16Bit = new ushort[tiff.ScanlineSize() / 2];

                    using (Tiff output = Tiff.Open("dummy\\process.tif", "w"))
                    {
                        if (output == null)
                            return null;

                        output.SetField(TiffTag.IMAGEWIDTH, width);
                        output.SetField(TiffTag.IMAGELENGTH, height);
                        output.SetField(TiffTag.BITSPERSAMPLE, 16);
                        output.SetField(TiffTag.SAMPLESPERPIXEL, 1);
                        output.SetField(TiffTag.PHOTOMETRIC, Photometric.MINISBLACK);
                        output.SetField(TiffTag.PLANARCONFIG, PlanarConfig.CONTIG);
                        output.SetField(TiffTag.ROWSPERSTRIP, 1);
                        output.SetField(TiffTag.COMPRESSION, Compression.LZW);

                        for (int i = 0; i < height; i++)
                        {
                            tiff.ReadScanline(scanline, i);
                            MultiplyScanLineAs16BitSamples(scanline, scanline16Bit, 16);
                            output.WriteScanline(scanline, i);
                        }
                    }

                    using (Bitmap img = new Bitmap("dummy\\process.tif"))
                    {
                        using (Bitmap img2 = SetContrast(50, img, 0.1))
                        {
                            using (Bitmap img3 = Transform(img2))
                            {
                                return (Image)img3.Clone();
                            }
                        }
                    }
                }
            }

            private static void MultiplyScanLineAs16BitSamples(byte[] scanline, ushort[] temp, ushort factor)
            {
                if (scanline.Length % 2 != 0)
                {
                    // each two bytes define one sample so there should be even number of bytes
                    throw new ArgumentException();
                }

                // pack all bytes to ushorts
                Buffer.BlockCopy(scanline, 0, temp, 0, scanline.Length);

                for (int i = 0; i < temp.Length; i++)
                    temp[i] *= factor;

                // unpack all ushorts to bytes
                Buffer.BlockCopy(temp, 0, scanline, 0, scanline.Length);
            }

            public static Bitmap SetContrast(double contrast, Bitmap bmap, double _val)
            {
                    if (contrast < -100) contrast = -100;
                    if (contrast > 100) contrast = 100;
                    contrast = (100.0 + contrast) / 100.0;
                    contrast *= contrast;
                    Color c;

                    double _value = _val;

                    for (int i = 0; i < bmap.Width; i++)
                    {
                        for (int j = 0; j < bmap.Height; j++)
                        {
                            c = bmap.GetPixel(i, j);
                            double pR = c.R / 255.0;
                            pR -= _value;
                            pR *= contrast;
                            pR += _value;
                            pR *= 255;
                            if (pR < 0) pR = 0;
                            if (pR > 255) pR = 255;

                            double pG = c.G / 255.0;
                            pG -= _value;
                            pG *= contrast;
                            pG += _value;
                            pG *= 255;
                            if (pG < 0) pG = 0;
                            if (pG > 255) pG = 255;

                            double pB = c.B / 255.0;
                            pB -= _value;
                            pB *= contrast;
                            pB += _value;
                            pB *= 255;
                            if (pB < 0) pB = 0;
                            if (pB > 255) pB = 255;

                            bmap.SetPixel(i, j, Color.FromArgb((byte)pR, (byte)pG, (byte)pB));
                        }
                    }

                    return bmap;
                
            }

            //public static Image SetInvert(Image bmp)
            //{
            //    using (Bitmap bmap = (Bitmap)bmp.Clone())
            //    {
            //        Color c;
            //        for (int i = 0; i < bmap.Width; i++)
            //        {
            //            for (int j = 0; j < bmap.Height; j++)
            //            {
            //                c = bmap.GetPixel(i, j);
            //                bmap.SetPixel(i, j, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
            //            }
            //        }

            //        bmp = (Bitmap)bmap.Clone();
            //        return bmp;
            //    }
            //}

            ////public static Bitmap Ters(Bitmap Image)
            ////{
            ////    Color c;
            ////    for (int i = 0; i < Image.Width; i++)
            ////    {
            ////        for (int j = 0; j < Image.Height; j++)
            ////        {
            ////            c = Image.GetPixel(i, j);
            ////            c = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
            ////            Image.SetPixel(i, j, c);
            ////        }
            ////    }
            ////    return Image;
            ////}


            public static Bitmap Transform(Bitmap source)
            {
                //create a blank bitmap the same size as original
                Bitmap newBitmap = new Bitmap(source.Width, source.Height);

                //get a graphics object from the new image
                Graphics g = Graphics.FromImage(newBitmap);

                // create the negative color matrix
                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
            {
                new float[] {-1, 0, 0, 0, 0},
                new float[] {0, -1, 0, 0, 0},
                new float[] {0, 0, -1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {1, 1, 1, 0, 1}
            });

                // create some image attributes
                ImageAttributes attributes = new ImageAttributes();

                attributes.SetColorMatrix(colorMatrix);

                g.DrawImage(source, new Rectangle(0, 0, source.Width, source.Height),
                            0, 0, source.Width, source.Height, GraphicsUnit.Pixel, attributes);

                //dispose the Graphics object
                g.Dispose();

                return newBitmap;
            }
        }
    }
}