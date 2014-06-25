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
    }
}
