using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathBarld.ProjectEuler
{
    public class Problem4 : IProblem
    {
        public string ProblemDescription => @"A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.d";

        public long GetAnswer()
        {
            int maxpal = 0;

            for(int i=999;i>0;i--)
            {
                for(int j=999;j>0;j--)
                {
                    if (i * j < maxpal)
                        break;
                    else if ((i * j).IsPalindrome())
                        maxpal = i * j;
                }
            }

            return (long)maxpal;
        }
    }
}