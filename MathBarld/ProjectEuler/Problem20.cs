using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld.ProjectEuler
{
    public class Problem20 : IProblem
    {
        public string ProblemDescription => @"n! means n × (n − 1) × ... × 3 × 2 × 1

For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

Find the sum of the digits in the number 100!";

        public long GetAnswer()
        {
            BigInteger number = 100;
            for (BigInteger i = 99; i > 0; i--) 
            {
                number *= i;
            }
            long sum = 0;
            foreach(var num in number.ToString())
            {
                sum += (long)Char.GetNumericValue(num);
            }
            return sum;
        }
    }
}
