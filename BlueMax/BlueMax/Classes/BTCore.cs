using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueMax.Classes
{
    public class BTCore
    {
        public static string EncryptToBase64(string text)
        {
            byte[] EncryptAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(text);
            string value = System.Convert.ToBase64String(EncryptAsBytes);
            return value;
        }
    }
}
