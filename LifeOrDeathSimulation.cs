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
            var random = new Random();
            for (int row = 0; row < RowsCount; row++)
            {
                for (int col = 0; col < ColumnsCount; col++)
                {
                    matrix[row, col] = random.Next(2);
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
            List<int> rowEdgeCases = new List<int>() { 0, RowsCount - 1 };
            List<int> columnEdgeCases = new List<int>() { 0, ColumnsCount - 1 };

            Dictionary<int, string> mappings = new Dictionary<int, string>()
            {
                { 0, " " },
                { 1, "S" }
            };

            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < RowsCount; row++)
            {
                for (int col = 0; col < ColumnsCount; col++)
                    if (rowEdgeCases.Contains(row) || columnEdgeCases.Contains(col))
                        sb.Append("X");
                    else
                        sb.Append(mappings[Matrix[row, col]]);
                sb.AppendLine();
            }
            return sb.ToString();
        }

    }
}
