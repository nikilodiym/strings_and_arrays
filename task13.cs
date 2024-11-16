using System;

namespace MatrixOperations
{
    public class Matrix
    {
        private int[,] data;
        private int rows;
        private int columns;

        public Matrix(int[,] data)
        {
            this.data = data;
            this.rows = data.GetLength(0);
            this.columns = data.GetLength(1);
        }

        public void MultiplyByScalar(int scalar)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    data[i, j] *= scalar;
                }
            }
        }

        public static Matrix Add(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            int[,] result = new int[matrix1.rows, matrix1.columns];

            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.columns; j++)
                {
                    result[i, j] = matrix1.data[i, j] + matrix2.data[i, j];
                }
            }

            return new Matrix(result);
        }

        public static Matrix Multiply(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.columns != matrix2.rows)
            {
                throw new ArgumentException("The number of columns in the first matrix must be equal to the number of rows in the second matrix.");
            }

            int[,] result = new int[matrix1.rows, matrix2.columns];

            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix2.columns; j++)
                {
                    for (int k = 0; k < matrix1.columns; k++)
                    {
                        result[i, j] += matrix1.data[i, k] * matrix2.data[k, j];
                    }
                }
            }

            return new Matrix(result);
        }
    }
}
