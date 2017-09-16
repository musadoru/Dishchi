using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueMax.DAL
{
    public class Hasta
    {
        public int ID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string tcKimlik { get; set; }
        public DateTime dogumTarihi { get; set; }
        public DateTime kayitTarihi { get; set; }
    }
}
