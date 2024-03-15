using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace modul1
{
    public class Matrix
    {
        public int[][] mat { get; set; }
        Random random = new Random();
        public int row { get; set; }
        public int col { get; set; }
        public void FillMatrixRandom(int rows, int columns, int min, int max)
        {
            mat = new int[rows][];
            row = rows;
            col = columns;
            for (int i = 0; i < rows; i++)
            {
                mat[i] = new int[columns];
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mat[i][j] = random.Next(min, max);
                }
            }
        }
        public int this[int row, int column] { get { return mat[row][column]; } set { mat[row][column] = value; } }
    }
}
