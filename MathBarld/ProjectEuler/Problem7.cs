using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathBarld.Priems;

namespace MathBarld.ProjectEuler
{
    public class Problem7 : IProblem
    {
        public string ProblemDescription => @"By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?";

        public long GetAnswer() => (long)GetPriemN(10001);
    }
}
