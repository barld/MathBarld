using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld
{
    public class Combination
    {
        public int Number { get; set; }
        public int K { get; set; }

        public int Value
        {
            get
            {
                return (Faculteit.GetIteratiev(Number)) / (Faculteit.GetIteratiev(K) * Faculteit.GetIteratiev(Number - K));
            }
        }

        public Combination(int number, int combination)
        {
            K = combination;
            Number = number;
        }


    }
}
