using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathBarld.Sudoku;
using System.Collections.Generic;

namespace MathBarldTest
{
    [TestClass]
    public class SudokuTests
    {
        List<int[,]> sudokuData = new List<int[,]>()
        {
            new int[9,9] {
                { 0,0,3,0,2,0,6,0,0 },
                { 9,0,0,3,0,5,0,0,1 },
                { 0,0,1,8,0,6,4,0,0 },
                { 0,0,8,1,0,2,9,0,0 },
                { 7,0,0,0,0,0,0,0,8 },
                { 0,0,6,7,0,8,2,0,0 },
                { 0,0,2,6,0,9,5,0,0 },
                { 8,0,0,2,0,3,0,0,9 },
                { 0,0,5,0,1,0,3,0,0 }
            }
        };

        [TestMethod]
        public void SolveSudoku0()
        {
            var s = new Sudoku(sudokuData[0]);
            var solver = new SudokuSolver(s);

            solver.Solve();

            Assert.IsTrue(solver.IsSolved);
        }
    }
}
