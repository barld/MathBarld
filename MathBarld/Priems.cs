using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld
{
    static public class Priems
    {
        static List<int> listPriems = new List<int>();

        public static List<int> GetAllPriemsBelow(int below)
        {
            if (listPriems.Count == 0)
            {
                listPriems.Add(2);
                listPriems.Add(3);
            }
            if(listPriems.Last()>below)
            {
                return listPriems.Where(x => x < below).ToList<int>();
            }
            for(int i = listPriems.Last()+2;i<below;i+=2)
            {
                int sqrtI = (int)Math.Sqrt((double)i);
                bool isPriem = true;
                foreach(int priem in listPriems)
                {
                    if (sqrtI < priem) break;
                    if(i%priem==0)
                    {
                        isPriem = false;
                        break;
                    }
                }
                if (isPriem)
                    listPriems.Add(i);
            }

            return listPriems;
        }

        public static bool IsPriem(int possiblePriem)
        {
            if (listPriems.Last() < possiblePriem) GetAllPriemsBelow(possiblePriem);

            return listPriems.Exists(x => x == possiblePriem);
        }

        private static IEnumerable<int> GetRange(int from, int to)
        {
            for (int i = from; i <= to; i += 2)
                yield return i;

        }

        public static List<int> GetPriemsBelowParallel(int tot)
        {
            //geoptimaliseert om alle priemgetallen onder maximaal 5 764 801 te vinden.
            // namelijk 5 764 801 == 7^2^2^2
            List<int> PriemList = new List<int>(new int[] { 2, 3, 5, 7 });
            object priemLock = new object();
            do
            {
                PriemList.Sort();
                int[] IteratePriems = PriemList.ToArray();
                //stop
                int stop = IteratePriems.Last() * IteratePriems.Last();
                if (stop > tot || stop < 0)
                {
                    stop = tot;
                    int sqrt = (int)Math.Sqrt(tot)+1;
                    IteratePriems = IteratePriems.Where(x => x <= sqrt).ToArray();
                }



                Parallel.ForEach(GetRange(PriemList.Last() + 2, stop), (i) =>
                {
                    bool isPriem = true;
                    foreach (int priem in IteratePriems)
                    {
                        if (i % priem == 0)
                        {
                            isPriem = false;
                            break;
                        }
                    }
                    if (isPriem)
                    {
                        lock (priemLock)
                        {
                            PriemList.Add(i);
                        }
                    }
                }
                );

                if (stop == tot)
                    break;
            }
            while (true);

            return PriemList;
        }

        public static int GetPriemN(int n)
        {
            List<int> priems = new List<int>(new int[] { 2 });

            for (int i = 3; ; i += 2)
            {
                bool isPriem = true;
                foreach (int priem in priems)
                {
                    if (i % priem == 0)
                    {
                        isPriem = false;
                        break;
                    }
                }
                if (isPriem)
                    priems.Add(i);

                if (priems.Count == n)
                    return i;
            }

        }
    }
}
