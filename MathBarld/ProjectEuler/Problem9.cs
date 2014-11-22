using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld.ProjectEuler
{
    public class Problem9 : IProblem
    {
        public string ProblemDescription => @"A Pythagorean triplet is a set of three natural numbers, a < b<c, for which,

a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.";

        public long GetAnswer()
        {
            for(int i=998; ;i--)
            {
                for(int j =999-i;j>0;j--)
                {
                    if(j*j+(1000-i-j)* (1000 - i - j) == i*i)
                        return (long)j*(long)(1000-i-j)*(long)i;
                }
            }
        }
    }
}
