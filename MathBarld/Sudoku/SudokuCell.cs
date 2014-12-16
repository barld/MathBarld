using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld.Sudoku
{
    public class SudokuCell
    {
        public List<int> PosibleAnswers { get; internal set; }

        public int? Answer { get; internal set; }

        public bool HasAnswer
        {
            get
            {
                return Answer == null;
            }
        }

        public SudokuCell()
        {
            PosibleAnswers = Enumerable.Range(1, 9).ToList();
        }

        public SudokuCell(int value)
        {
            Answer = value;
            PosibleAnswers = new List<int>();
        }
    }
}
