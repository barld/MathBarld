using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld
{
    public static class Palindrome
    {
        public static bool IsPalindrome(this string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            for(int i = input.Length;i>0 ;i--)
            {
                if(input[i-1] != input[input.Length-i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPalindrome(this string input, bool DeleteSpaces)
        {
            if(DeleteSpaces)
                return input.Replace(" ", string.Empty).IsPalindrome();
            return input.IsPalindrome();
        }

        public static bool IsPalindrome(this int input)
        {
            return input.ToString().IsPalindrome();
        }
    }
}
