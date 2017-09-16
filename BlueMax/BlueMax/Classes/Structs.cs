using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueMax.Classes
{
    public delegate void CallBackFunc(IntPtr Ptr_arglist);

    public struct IFD_Entry
    {
        public short tag;

        public short type;

        public long count;

        public long @value;
    }

    public struct PIXMAPENTRY
    {
        public char type;

        public ushort x1;

        public ushort x2;

        public ushort y1;

        public ushort y2;

        public ushort mask;

        public char flag;
    }

    public struct strImageAcq
    {
        public int theHandle;

        public IntPtr theImageBuf;

        public IntPtr theImageBufSizePtr;

        public IntPtr theTimeout;

        public int ImageStatus;

        public CallBackFunc AcqImageCallBack;

        public IntPtr CallBackParameters;
    }

    public struct strInitSensor
    {
        public string theInitFile;

        public CallBackFunc IniSensorCallBack;

        public IntPtr CallBackParameters;
    }

    public struct TiffHeader
    {
        public short ByteOrder;

        public short FortyTwo;

        public long IFDoffset;

        public short spacer;

        public short IFDentries;

        public IFD_Entry[] IFDentry;

        public long FourZeroes;

        public long xResNum;

        public long xResDen;

        public long yResNum;

        public long yResDen;

        public char[] software;
    }

    public struct timeval
    {
        public uint tv_sec;

        public uint tv_usec;
    }
}
