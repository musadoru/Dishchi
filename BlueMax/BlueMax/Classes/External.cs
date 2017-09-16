using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace BlueMax.Classes
{
    public class External
    {
        public static bool sensorConnection = false;

        public static int sensorNo = 0;
        public static string sensorSize = string.Empty;
        public static string btkNS = string.Empty;
        public static string digiGain = string.Empty;
        public static string intTime = string.Empty;
        public static string thresHold = string.Empty;
        public static string readOut = string.Empty;
        public static string timeOut = string.Empty;
        public static string bek = "TTFXVko1WTQ=";
        public static int theHandle = -1;
        public static float[] DigiGain = new float[1];
        public static ushort[] IntTime = new ushort[1];
        public static EnumManager.TRI_tReadOutMode[] theReadOutMode = new EnumManager.TRI_tReadOutMode[1];
        public static byte[] theThreshold = new byte[1];
        public static byte[] theCurrentSN = new byte[16];
        public static uint[] theImageBufSize = new uint[1];
        public static ushort[] theNumLines = new ushort[1];
        public static timeval[] theTimeOut = new timeval[1];
        public static ushort[] theLineLength = new ushort[1];

        public static int theStatus;

        #region _importDll
        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ComputePixelMap(IntPtr pOfstImg, IntPtr pGainImg, int nRows, int nCols, int GainDefectMin, int GainDefectMax, int DarkDefectMax, string pixFileName);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_AcquireImage_Ori(int theHandle, [In] byte[] theImageBuf, IntPtr theImageBufSizePtr, IntPtr theTimeout);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern void TRI_CancelImageAcquisition();

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_Capture(int theHandle, EnumManager.TRI_tCaptureReq theReq);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern void TRI_CleanUp();

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_Close(int theHandle);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_Disable(int theHandle);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_DoCorrections(IntPtr imageBuffer, string fileNameOffset, string fileNmaeGain, string fileNamePixelMap, ushort theLineLength, ushort theNumLines, ushort correctionMode);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_Enable(int theHandle);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_GetDigitalGain(int theHandle, IntPtr theGain);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_GetImageDimensions(int theHandle, IntPtr theNumLines, IntPtr theLineLength);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern uint TRI_GetImageSize(int theHandle);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_GetIntegrationTime(int theHandle, IntPtr theIntegrationTime);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_GetNumPresent();

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_GetReadOutMode(int theHandle, IntPtr theReadOutMode);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_GetRegisterValue(int theHandle, IntPtr regiValue, byte theReg);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern EnumManager.TRI_tSensorType TRI_GetSensorType(int theHandle);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_GetSerialNum(int theHandle, IntPtr theBuf, int theBufSize);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_GetThresholdLevel(int theHandle, IntPtr theThreshold);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_GetTrueImageBuffer(IntPtr theTrueImageBuf, IntPtr theImageBuf, uint theImageSize, uint numPixels);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern void TRI_Init_Ori(string theInitFile);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_Open(char[] theSerialNum);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_Save(int theHandle, string theFileName, EnumManager.TRI_tFormat theFormat, IntPtr theImageBuf, uint theImageBufSize);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_SetDigitalGain(int theHandle, float theGain);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_SetIntegrationTime(int theHandle, ushort theIntegrationTime);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_SetReadOutMode(int theHandle, EnumManager.TRI_tReadOutMode theReadOutMode);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_SetRegisterValue(int theHandle, byte regiValue, byte theReg);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_SetThresholdLevel(int theHandle, byte theThreshold);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_WriteBufferInRaw(string theFileName, IntPtr imageBuffer, ushort theNumberLines, ushort theLineLength);

        [DllImport("libtrident.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int TRI_WriteBufferInTiff(string theFileName, IntPtr imageBuffer, ushort theNumberLines, ushort theLineLength);

        [DllImport("Scilib21.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern ushort ScGainCorrection(IntPtr imgBuf, IntPtr gainBuf, uint nWidth, uint nHeight, ushort nMean);

        [DllImport("Scilib21.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern ushort ScOffsetCorrection(IntPtr imgBuf, IntPtr ofstBuf, uint nWidth, uint nHeight);

        [DllImport("Scilib21.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern ushort ScPixelCorrection(IntPtr imgBuf, uint nWidth, uint nHeight, IntPtr pixMap, uint nPixMapCount, ushort pcMethod);

        [DllImport("Scilib21.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern ushort ScReadPixMap(string filePath, IntPtr pixMap, IntPtr numEntries);

        #endregion _importDll
    }
}
