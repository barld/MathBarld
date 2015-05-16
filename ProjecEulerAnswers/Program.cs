using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathBarld.ProjectEuler;

namespace ProjecEulerAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region problems
            List<IProblem> problems =
                new List<IProblem>()
                {
                    new Problem1(),
                    new Problem2(),
                    new Problem3(),
                    new Problem4(),
                    new Problem5(),
                    new Problem6(),
                    new Problem7(),
                    new Problem8(),
                    new Problem9(),
                    new Problem10(),
                    new Problem11(),
                    new Problem12(),
                    new Problem13(),
                    new Problem14(),
                    new Problem15(),
                    new Problem16(),
                    new Problem18(),
                    new Problem19(),
                    new Problem20(),
                    new Problem22(),
                    new Problem25(),
                };
            #endregion

            bool ProgramRun = true;

            while(ProgramRun)
            {
                Console.Write(@"Kies hoe verder te gaan
q) close program
l) voor lijst met probleemen
voor een cijfer in om het probleem te krijgen

"
                    );

                string answer = Console.ReadLine();
                switch(answer)
                {
                    case "q":
                        ProgramRun = false;
                        break;
                    case "l":
                        foreach(IProblem problem in problems)
                        {
                            Console.WriteLine(problem.GetType().Name);
                        }
                        break;
                    default:
                        int number;
                        if(int.TryParse(answer, out number))
                        {
                            if (!problems.Exists(p => p.GetType().Name == "Problem" + answer))
                            {
                                Console.WriteLine("Problem don't exists");
                            }
                            else
                            {
                                System.Diagnostics.Stopwatch stp = new System.Diagnostics.Stopwatch();
                                stp.Start();
                                Console.WriteLine(problems.First(p => p.GetType().Name == "Problem" + answer).GetAnswer());
                                stp.Stop();
                                Console.WriteLine(stp.Elapsed.ToString());
                                Console.WriteLine();
                            }
                        }
                        break;
                }
            }
        }
    }
}
