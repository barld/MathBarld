using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld
{
    public static class Collatz
    {
        static Dictionary<int, int> collatzCountCollections = new Dictionary<int, int>();
        public static int GetCollectionCountRecursief(int n)
        {
            if (n == 1)
                return 1;
            else if (collatzCountCollections.ContainsKey(n))
                return collatzCountCollections[n];
            else
            {
                int nl;
                if (n % 2 == 0)
                    nl = GetCollectionCountRecursief(n / 2);
                else
                    nl = GetCollectionCountRecursief(3 * n + 1);

                nl++;
                collatzCountCollections[n] = nl;

                return nl;
            }
        }
    }
}
