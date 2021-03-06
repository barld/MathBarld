﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathBarld;

namespace MathBarld.ProjectEuler
{
    public class Problem3 : IProblem
    {
        public string ProblemDescription
        {
            get
            {
                return @"The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?";
            }
        }

        public long GetAnswer()
        {
            Int64 StartNumber = 600851475143;
            int maxnumber = (int)Math.Sqrt((double)StartNumber);

            int max = 0;

            foreach(int priem in Priems.GetPriemsBelowParallel(maxnumber))
            {
                if (StartNumber % priem == 0 && max < priem)
                    max = priem;
            }



            return (long)max;
        }
    }
}
