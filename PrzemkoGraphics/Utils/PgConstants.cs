using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrzemkoGraphics.Utils
{
    public static class PgConstants
    {
        public static readonly string ChangedFilesPath = @"C:\Users\Intuo\Desktop\babymetal\changed\";

        public static Regex RegexNumbers = new Regex(@"^[0-9]+$");
    }
}
