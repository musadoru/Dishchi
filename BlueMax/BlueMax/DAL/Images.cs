using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueMax.DAL
{
    public class Images
    {
        public int Id { get; set; }
        public int PatientID { get; set; }
        public string ImgName { get; set; }
        public string ImgDate { get; set; }
        public int ImgType { get; set; }
    }
}
