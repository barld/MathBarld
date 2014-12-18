using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld.Sudoku
{
    public class SudokuSolver
    {
        private static ISolver[] SolveMethods =
            {
                new HorizontalSolving(),
                new VerticalSolving(),
                new InBoxSolving(),
                new OnlyOneInBoxSolving(),
                //new CandidateLinesHorizontalSolving(),//not stable

            };

        public Sudoku Sudoku { get; private set; }

        public bool IsSolved
        {
            get
            {
                //kijk nu alleen simpel of iedere cell een antwoord heeft
                for(int i=0;i<81;i++)
                    if (!Sudoku.SudokuCells[i / 9, i % 9].HasAnswer)
                        return false;
                return true;
            }
        }

        public bool Solve()
        {
            do
            {
                foreach (ISolver solver in SolveMethods)
                {
                    solver.TrySolve(this.Sudoku);
                }
            }
            while (!IsSolved);
            

            return IsSolved;
        }

        public Task<bool> SolveAsync()
        {
            throw new System.NotImplementedException();
        }

        public SudokuSolver(Sudoku sudoku)
        {
            Sudoku = sudoku;
        }

        #region solving logic

        interface ISolver
        {
            void TrySolve(Sudoku sudoku);
        }

        class HorizontalSolving : ISolver
        {
            public void TrySolve(Sudoku sudoku)
            {
                for(int i=0;i<81;i++)
                {
                    if (sudoku.SudokuCells[i / 9, i % 9].HasAnswer)
                        continue;
                    else
                    {
                        SudokuCell cell = sudoku.SudokuCells[i / 9, i % 9];
                        for(int j=0;j<9;j++)
                        {
                            if (sudoku.SudokuCells[i / 9, j].HasAnswer)
                                cell.PosibleAnswers.Remove((sudoku.SudokuCells[i / 9, j].Answer ?? 0));
                        }
                        if (cell.PosibleAnswers.Count == 1)
                            cell.Answer = cell.PosibleAnswers.First();
                    }
                }
            }
        }

        class VerticalSolving : ISolver
        {
            public void TrySolve(Sudoku sudoku)
            {
                for (int i = 0; i < 81; i++)
                {
                    if (sudoku.SudokuCells[i / 9, i % 9].HasAnswer)
                        continue;
                    else
                    {
                        SudokuCell cell = sudoku.SudokuCells[i / 9, i % 9];
                        for (int j = 0; j < 9; j++)
                        {
                            if (sudoku.SudokuCells[j, i%9].HasAnswer)
                                cell.PosibleAnswers.Remove((sudoku.SudokuCells[j, i % 9].Answer ?? 0));
                        }
                        if (cell.PosibleAnswers.Count == 1)
                            cell.Answer = cell.PosibleAnswers.First();
                    }
                }
            }
        }

        class InBoxSolving : ISolver
        {
            public void TrySolve(Sudoku sudoku)
            {
                for (int i = 0; i < 81; i++)
                {
                    if (sudoku.SudokuCells[i / 9, i % 9].HasAnswer)
                        continue;
                    else
                    {
                        SudokuCell cell = sudoku.SudokuCells[i / 9, i % 9];
                        
                        for(int j=0;j<9;j++)
                        {
                            if (sudoku.SudokuCells[((i / 9) / 3) * 3 + j / 3, ((i % 9) / 3) * 3 + j % 3].HasAnswer)
                                cell.PosibleAnswers.Remove((sudoku.SudokuCells[((i / 9) / 3) * 3 + j / 3, ((i % 9) / 3) * 3 + j % 3].Answer ?? 0));
                        }
                        if (cell.PosibleAnswers.Count == 1)
                            cell.Answer = cell.PosibleAnswers.First();
                    }
                }
            }
        }

        class OnlyOneInBoxSolving : ISolver
        {
            public void TrySolve(Sudoku sudoku)
            {
                for (int i = 0; i < 81; i++)
                {
                    if (sudoku.SudokuCells[i / 9, i % 9].HasAnswer)
                        continue;
                    else
                    {
                        SudokuCell cell = sudoku.SudokuCells[i / 9, i % 9];

                        foreach(int value in cell.PosibleAnswers)
                        {
                            bool arePosible = true;
                            for (int j = 0; j < 9; j++)
                            {
                                if (sudoku.SudokuCells[((i / 9) / 3) * 3 + j / 3, ((i % 9) / 3) * 3 + j % 3].PosibleAnswers.Exists(x => x == value))
                                    arePosible = false;
                            }
                            if (arePosible)
                                cell.Answer = value;
                        }
                        if (cell.HasAnswer)
                            cell.PosibleAnswers.Clear();
                    }
                }
            }
        }

        class CandidateLinesHorizontalSolving : ISolver
        {
            public void TrySolve(Sudoku sudoku)
            {
                //iterate boxes
                for(int box=0;box<9;box++)
                {
                    for(int i = 0;i<9;i++)
                    {
                        var cell = sudoku.SudokuCells[(box / 3) * 3 + i / 3, (box % 3) * 3 + i % 3];
                        if (cell.HasAnswer) continue;

                        foreach (int valueToCheck in cell.PosibleAnswers)
                        {
                            bool hasValue = false;
                            for(int j =0;j<9;j++)
                            {
                                //in zelfde rij skip
                                if (j / 3 == i / 3) continue;

                                if(sudoku.SudokuCells[(box / 3) * 3 + j / 3, (box % 3) * 3 + j % 3].PosibleAnswers.Contains(valueToCheck))
                                {
                                    hasValue = true;
                                    break;
                                }
                            }
                            //er mag worden gestreept als dit waar is
                            if(!hasValue)
                            {
                                for(int j = 0;j<9;j++)
                                {
                                    //mag niet in dezelfde box zitten
                                    if (box % 3 == j / 3) continue;

                                    if(sudoku.SudokuCells[(box / 3) * 3 + i / 3, j].PosibleAnswers.Remove(valueToCheck))
                                        if (sudoku.SudokuCells[(box / 3) * 3 + i / 3, j].PosibleAnswers.Count == 1)
                                            cell.Answer = sudoku.SudokuCells[(box / 3) * 3 + i / 3, j].PosibleAnswers.First();
                                }
                            }
                        }                        
                    }
                }
            }
        }

        #endregion
    }
}
