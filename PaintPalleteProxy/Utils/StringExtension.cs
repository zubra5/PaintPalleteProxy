using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintPalleteProxy.Utils
{
    public static class StringExtension
    {
        public static string CapitalFirstLetter(this string str)
        {
            return str.Substring(0,1).ToUpper()+str.Substring(1).ToLower();
        }
    }
}
