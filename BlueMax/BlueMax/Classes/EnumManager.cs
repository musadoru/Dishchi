using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BlueMax.Classes
{
    public class EnumManager
    {
        public enum Cinsiyet : byte
        {
            [DisplayAttribute(Name = "Bay")]
            Bay = 1,

            [DisplayAttribute(Name = "Bayan")]
            Bayan = 2
        }

        public enum TRI_tReadOutMode
        {
            TRI_READOUT_LEFT2RIGHT_TOP2BOTTOM,
            TRI_READOUT_RIGHT2LEFT_TOP2BOTTOM,
            TRI_READOUT_LEFT2RIGHT_BOTTOM2TOP,
            TRI_READOUT_RIGHT2LEFT_BOTTOM2TOP,
            TRI_READOUT_MAX,
            TRI_READOUT_UNKNOWN
        }

        public enum TRI_tSensorType
        {
            TRI_SIZE1_SMALL,
            TRI_SIZE2_LARGE,
            TRI_SIZE_UNKNOWN
        }

        public enum TRI_tFormat
        {
            TRI_FORMAT_RAW,
            TRI_FORMAT_PIXELSONLY,
            TRI_FORMAT_MAX,
            TRI_FORMAT_UNKNOWN,
            TRI_FORMAT_TIFF
        }

        public enum TRI_tCaptureReq
        {
            TRI_CAPTURE_STOP,
            TRI_CAPTURE_MANUAL,
            TRI_CAPTURE_INTEGRATION,
            TRI_CAPTURE_XRAY,
            TRI_CAPTURE_TEST,
            TRI_CAPTURE_CONTINUOUS,
            TRI_CAPTURE_MAX,
            TRI_CAPTURE_UNKNOWN
        }
    }
}
