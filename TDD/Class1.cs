using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    public class Class1
    {
        public static int Choose_max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        public static int Choose_min(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }

    }
}
