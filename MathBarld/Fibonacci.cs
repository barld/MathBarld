using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld
{
    public class Fibonacci
    {
        static int f1 = 1;
        static int f2 = 1;

        public static int GetFibonacciNumberRecursive(int number)
        {
            if (number == 1)
                return f1;
            else if (number == 2)
                return f2;
            else
                return GetFibonacciNumberRecursive(number - 1) + GetFibonacciNumberRecursive(number - 2);
        }

        public static int GetFibonacciNumberIterative(int number)
        {
            if (number == 1)
                return f1;
            else if (number == 2)
                return f2;
            else
            {
                int t1 = f1;
                int t2 = f2;
                int rtw = 0;

                do
                {
                    rtw = t1 + t2;

                    t2 = t1;
                    t1 = rtw;

                    number--;
                }
                while (number > 2);

                return rtw;
            }
        }
    }
}
