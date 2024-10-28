using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace DSADemo.Array2D
{
    public class Matrix
    {
        public bool Search(int[][] matrix, int target)
        {
            // Get the number of rows
            int rowCount = matrix.Length;

            // Get the number of columns
            int colCount = matrix[0].Length;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (matrix[i][j] == target)
                    {
                        System.Console.Write("found at row " + i + " column " + j);
                        return true;
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("not found");
            return false;
        }
        public void Test()
        {
            int[][] matrix =
            [
                [1,2,3,4],
                [5,6,7,8],
                [9,10,11,12]
            ];

            Search(matrix, 15);
        }
    }
}