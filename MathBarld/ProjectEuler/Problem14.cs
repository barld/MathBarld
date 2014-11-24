using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld.ProjectEuler
{
    public class Problem14 : IProblem
    {
        public string ProblemDescription => @"The following iterative sequence is defined for the set of positive integers:

n → n/2 (n is even)
n → 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:

13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

NOTE: Once the chain starts the terms are allowed to go above one million.";

        public long GetAnswer()
        {
            int startnumber = 0;
            long longest = 0;
            for(int i=1;i<1000000;i++)
            {
                var aantals = MathBarld.Collatz.GetCollectionCountIteratief(i);
                if (aantals > longest)
                {
                    longest = aantals;
                    startnumber = i;
                }
            }
            return (long)startnumber;
        }
    }
}
