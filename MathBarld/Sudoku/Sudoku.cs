using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBarld.Sudoku
{
    public class Sudoku
    {
        #region public properties
        public SudokuCell[,] SudokuCells { get; private set; }

        /*public bool IsSolved
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }*/
        #endregion

        #region constructors
        public Sudoku()
        {
            //initialiseer empty sudokucells
            SudokuCells = new SudokuCell[9, 9];

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    SudokuCells[i, j] = new SudokuCell();
        }

        public Sudoku(SudokuCell[,] sudokuCells)
        {
            //input validatie
            if (sudokuCells == null) throw new ArgumentNullException(nameof(sudokuCells));
            else if (sudokuCells.GetLength(0) != 9 || sudokuCells.GetLength(1) != 9) throw new ArgumentException("both dimensions must be 9", nameof(sudokuCells));

            this.SudokuCells = sudokuCells;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sudokuValues">0 if empty</param>
        public Sudoku(int[] sudokuValues)
        {
            //input validatie
            if (sudokuValues == null) throw new ArgumentNullException(nameof(sudokuValues));
            if (sudokuValues.Length != 81) throw new ArgumentException("an sudoku has 81 values", nameof(sudokuValues));

            SudokuCells = new SudokuCell[9, 9];
            for (int i = 0; i < 81; i++)
                SudokuCells[i / 9, i % 9] = sudokuValues[i] == 0 ? new SudokuCell() : new SudokuCell(sudokuValues[i]);
        }

        public Sudoku(int[,] sudokuCellVallues)
        {
            //input validatie
            if (sudokuCellVallues == null) throw new ArgumentNullException(nameof(sudokuCellVallues));
            else if (sudokuCellVallues.GetLength(0) != 9 || sudokuCellVallues.GetLength(1) != 9) throw new ArgumentException("both dimensions must be 9", nameof(sudokuCellVallues));

            SudokuCells = new SudokuCell[9, 9];
            for (int i = 0; i < 81; i++)
                SudokuCells[i / 9, i % 9] = sudokuCellVallues[i / 9, i % 9] == 0 ? new SudokuCell() : new SudokuCell(sudokuCellVallues[i / 9, i % 9]);
        }

        #endregion

        #region simple get methods

        public SudokuCell[] GetRow(int index)
        {
            if (index < 0 || index > 8) throw new ArgumentOutOfRangeException(nameof(index), "value bust between 0 and 8");
            SudokuCell[] cells = new SudokuCell[9];
            for (int i = 0; i < 9; i++)
                cells[i] = SudokuCells[index, i];
            return cells;
        }

        public SudokuCell[] GetColumn(int index)
        {
            if (index < 0 || index > 8) throw new ArgumentOutOfRangeException(nameof(index), "value bust between 0 and 8");
            SudokuCell[] cells = new SudokuCell[9];
            for (int i = 0; i < 9; i++)
                cells[i] = SudokuCells[i,index];
            return cells;
        }
        #endregion

        public override string ToString()
        {
            string sudokuString = string.Empty;

            for(int i=0;i<81;i++)
            {
                sudokuString += "{SudokuCells[i / 9, i % 9].Answer ?? 0}\t";

                if (i % 9 == 8 && i != 81)
                    sudokuString += "\n";
            }

            return sudokuString;
        }
    }
}
