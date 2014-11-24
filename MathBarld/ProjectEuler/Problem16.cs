using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld.ProjectEuler
{
    public class Problem16 : IProblem
    {
        public string ProblemDescription => @"215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

What is the sum of the digits of the number 21000?";

        public long GetAnswer()
        {
            BigInteger number = new BigInteger(1);

            number = number << 1000;

            Console.WriteLine(number);

            long answer = 0;
            foreach(var n in number.ToString())
            {
                answer += (long)char.GetNumericValue(n);
            }

            return answer;
        }
    }
}
