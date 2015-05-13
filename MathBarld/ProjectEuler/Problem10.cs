using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathBarld;

namespace MathBarld.ProjectEuler
{
    public class Problem10 : IProblem
    {
        public string ProblemDescription => @"The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.";

        public long GetAnswer()
        {
            var priems = Priems.GetPriemsBelowParallel(2000 * 1000);
            return priems.Sum(pr => (long)pr);
        }
    }
}
