using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld.ProjectEuler
{
    public class Problem5 : IProblem
    {
        public string ProblemDescription => @"2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";

        public long GetAnswer()
        {
            for (int i = 20; ; i += 20)
            {
                bool divisable = true;
                for (int j = 19; j > 10; j--)
                {
                    if(i%j>0)
                    {
                        divisable = false;
                        break;
                    }
                }
                if (divisable)
                    return (long)i;
            }
        }
    }
}
