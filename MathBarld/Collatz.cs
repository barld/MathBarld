using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld
{
    public static class Collatz
    {
        static Dictionary<long, long> collatzCountCollections = new Dictionary<long, long>();
        public static int GetCollectionCountRecursief(int n)
        {
            if (n == 1)
                return 1;
            else if (collatzCountCollections.ContainsKey(n))
                return (int)collatzCountCollections[n];
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

        public static int GetCollectionCountIteratief(int n)
        {
            int rtw = 0;

            long i = n;

            while (true)
            {

                if (i == 1)
                {
                    rtw++;
                    break;
                }
                else if (collatzCountCollections.ContainsKey(i))
                {
                    rtw += (int)collatzCountCollections[i];
                    break;
                }
                else
                {
                    if (i % 2 == 0)
                        i = (i / 2);
                    else
                        i = (3 * i + 1);
                    rtw++;
                }
            }

            collatzCountCollections[n] = rtw;

            return rtw;
        }
    }
}
