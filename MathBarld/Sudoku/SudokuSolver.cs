using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld.Sudoku
{
    public class SudokuSolver
    {
        public Sudoku Sudoku { get; private set; }

        public bool IsSolved
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public bool Solve()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SolveAsync()
        {
            throw new System.NotImplementedException();
        }

        public SudokuSolver(Sudoku sudoku)
        {
            Sudoku = sudoku;
        }
    }
}
