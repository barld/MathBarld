using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld.ProjectEuler
{
    public class Problem22 : IProblem
    {
        public string ProblemDescription => @"Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.

For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.

What is the total of all the name scores in the file?";

        public long GetAnswer()
        {
            var client = new System.Net.WebClient();
            //get string from url
            var s = client.DownloadString(@"https://projecteuler.net/project/resources/p022_names.txt");
            // delete all '"'
            s = s.Replace("\"", "");
            //get all words
            var words = s.Split(',').ToList();

            words.Sort();

            int answer = 0;

            for(int i=0;i<words.Count;i++)
            {
                int score = 0;
                foreach(char c in words[i])
                {
                    score += c-64;
                }
                answer += score * (i + 1);
            }

            return (long)answer;
        }
        
    }
}
