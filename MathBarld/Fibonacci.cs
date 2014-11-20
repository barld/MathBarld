using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld
{
    public class Fibonacci
    {
        public static int GetFibonacciNumberRecursive(int number)
        {
            if (number <= 2)
                return 1;
            else
                return GetFibonacciNumberRecursive(number - 1) + GetFibonacciNumberRecursive(number - 2);
        }

        static List<int> numbers = new List<int>() { 0, 1, 1 };

        public static int RecursiveWithCache(int number)
        {
            if(numbers.Count < number+1)
            {                
                numbers.Add(RecursiveWithCache(number - 1) + RecursiveWithCache(number - 2));
            }
            return numbers[number];            
        }

        public static int GetFibonacciNumberIterative(int number)
        {
            if (number <= 2)
                return 1;
            else
            {
                int t1 = 1, t2 = 1, rtw = 0;
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
