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
        public static readonly string ChangedFilesPath = @"C:\Users\Intuo\Desktop\changed\";

        public static readonly Regex RegexNumbers = new Regex(@"^[0-9]+$");

        public static readonly int ValidMinSize = 1;
        public static readonly int ValidMaxSize = 3000;
    }
}
