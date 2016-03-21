namespace Homework
{
    using System;

    public class Matrix<T> where T : IComparable
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get { return this.rows; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rows cannot be negative number");
                }
                this.rows = value;
            }
        }

        public int Cols
        {
            get { return this.cols; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cols cannot be negative number");
                }
                this.cols = value;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Rows) ||
                    (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }
                return this.matrix[row, col];
            }

            set
            {
                if ((row < 0 || row >= this.Rows) || 
                    (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows ||
                firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("Matrices must have equal dimensions");
            }

            int newRows = firstMatrix.Rows + secondMatrix.Rows;
            int newCols = firstMatrix.Cols + secondMatrix.Cols;

            var newMatrix = new Matrix<T>(newRows, newCols);

            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows ||
                firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("Matrices must have equal sizes");
            }

            var newMatrix = new Matrix<T>(0, 0);

            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows == 0 || secondMatrix.Rows == 0 ||
                firstMatrix.Cols == 0 || secondMatrix.Cols == 0)
            {
                throw new ArgumentException("One of matrix dimensions is equal to zero");
            }

            var newMatrix = new Matrix<T>(firstMatrix.Rows * secondMatrix.Rows, firstMatrix.Cols * secondMatrix.Cols);

            return newMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return ContainsNonZeroElement(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return ContainsNonZeroElement(matrix);
        }

        private static bool ContainsNonZeroElement(Matrix<T> matrix)
        {
            foreach (var element in matrix.matrix)
            {
                if (!element.Equals(default(T)))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
