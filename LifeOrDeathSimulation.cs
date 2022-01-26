using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOrDeath11A
{
    class LifeOrDeathSimulation
    {

        private readonly int ColumnsCount;
        private readonly int RowsCount;

        private readonly int[,] Matrix;

        public LifeOrDeathSimulation(int columnsCount, int rowsCount)
        {
            ColumnsCount = columnsCount;
            RowsCount = rowsCount;
            Matrix = new int[RowsCount + 2, ColumnsCount + 2];
            InitializeMatrix(Matrix);
        }

        private void InitializeMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.Rank; row++)
            {
                for (int col = 0; col < ColumnsCount; col++)
                {
                    matrix[row, col] = 1;
                }
            }
            matrix[0, 0] = 0;
            matrix[0, ColumnsCount - 1] = 0;
            matrix[RowsCount - 1, 0] = 0;
            matrix[RowsCount - 1, ColumnsCount - 1] = 0;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < RowsCount; row++)
            {
                for (int col = 0; col < ColumnsCount; col++)
                {

                }
            }
            return null; // TODO
        }

    }
}
