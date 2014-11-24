using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld.ProjectEuler
{
    public class Problem15 : IProblem
    {
        public string ProblemDescription => @"Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.


How many such routes are there through a 20×20 grid?";

        public long GetAnswer()
        {
            List<List<long>> grid = new List<List<long>>();
            //fill grid
            for(int i=0;i<21;i++)
            {
                grid.Add(new List<long>());
                for(int j =0;j<21;j++)
                {
                    grid.Last().Add(1);
                }
            }

            for(int i=1;i<21;i++)
            {
                for (int j = 1; j < 21; j++)
                {
                    grid[i][j] = grid[i - 1][j] + grid[i][j - 1];
                }
            }

            

            return grid.Last().Last();
        }
    }
}
