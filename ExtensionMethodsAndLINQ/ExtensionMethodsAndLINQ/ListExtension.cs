﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsAndLINQ
{
    public static class ListExtension
    {
        public static bool Empty<T>(this List<T> list)
        {
            return list.Count == 0;
        }

        public static int Pow(this int a, int b)
        {
            if (b < 0)
            {
                throw new ArgumentException("exponent must be non negative.", nameof(b));
            }

            if (b == 0) { return 1; }

            int result;

            for (result = a; b>1; b--)
            {
                result *= a;
            }
            return result;
        }
    }
}
