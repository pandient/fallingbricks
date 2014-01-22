using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    /// <summary>
    /// This class will represent the grid board.
    /// </summary>
    public class Grid
    {
        private Cell[,] cells;
        public static readonly int HorizontalMax = 10;
        public static readonly int VerticalMax = 20;

        public Grid()
        {
            cells = new Cell[HorizontalMax, VerticalMax];
            InitTheGrid();
        }
        public void InitTheGrid()
        {
            for (int i = 0; i < HorizontalMax;i++)
            {
                for (int j = 0; j < VerticalMax; j++)
                {
                    cells[i,j] = new Cell();
                    
                }
            }

            for (int i = 0; i < HorizontalMax; i++)
            {
                for (int j = 0; j < VerticalMax; j++)
                {
                    if (j + 1 < VerticalMax)
                    {
                        cells[i, j].Up = cells[i, j + 1];
                    }
                    if(j - 1 >= 0)
                    {
                        cells[i, j].Down = cells[i, j - 1];
                    }
                    if( i + 1 < HorizontalMax)
                    {
                        cells[i, j].Right = cells[i + 1, j];
                    }
                    if(i - 1 >= 0)
                    {
                        cells[i, j].Left = cells[i - 1, j];
                    }

                }
            }
                return;
        }
        
        /// <summary>
        /// Add shape to the Grid
        /// </summary>
        /// <param name="shape"></param>
        void AddShape(Shape shape)
        {   
            
        }

        void MoveTheBlocks()
        {
           
        }

        void CheckForCompleteLines()
        {
            
        }

        void CheckForWinCondition()
        {
            
        }
    }

    internal class Cell
    {
        public Cell Up { get; set; }
        public Cell Down { get; set; }
        public Cell Left { get; set; }
        public Cell Right { get; set; }
        public Block CurrentBlock { get; set; }

    }
}
