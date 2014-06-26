using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld
{
    public static class Faculteit
    {
        public static int GetIteratiev(int input)
        {
            int rtw = 1;
            while(input > 0)
            {
                rtw *= input;
                input--;
            }
            return rtw;
        }

        public static int GetRecursive(int input)
        {
            if (input == 1) return 1;
            return input * GetRecursive(input - 1);
        }
    }
}
