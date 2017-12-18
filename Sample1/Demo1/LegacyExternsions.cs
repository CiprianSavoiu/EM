﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1.Demo1
{
    public static class LegacyExternsions
    {
        public static string ToLegacyFormat(this DateTime dateTime)
        {
            return dateTime.Year > 1930 ? dateTime.ToString("1yyMMdd") : dateTime.ToString("0yyMMdd");
        }

        public static string ToLegacyFormat(this string name)
        {
            var parts = name.ToUpper().Split(' ');
            return $"{parts[1]}, {parts[0]}";
        }

    }
}
