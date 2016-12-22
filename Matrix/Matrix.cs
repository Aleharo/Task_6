using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix
    {
        int[,] _matrix2D;

        public Matrix(int[,] a)
        {
            this._matrix2D = (int[,])a.Clone();
        }

        public Matrix(int a, int b)
        {
            this._matrix2D = new int[a, b];
        }

        public static Matrix operator +(Matrix a, Matrix b)
        // Matrix Addition 
        {
            if ((a.Rows != b.Rows) || (a.Columns != b.Columns))
                throw new IndexOutOfRangeException("I can't add these matrices, because they're not the same size."); 
            Matrix result = new Matrix(new int[a.Rows, a.Columns]);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }


        public static Matrix operator -(Matrix a, Matrix b)
        // Matrix Subtracting 
        {
            if ((a.Rows != b.Rows) || (a.Columns != b.Columns))
                throw new IndexOutOfRangeException("I can't substruct these matrices, because they're not the same size.");
            Matrix result = new Matrix(new int[a.Rows, a.Columns]);
            for (int i=0; i<a.Rows; i++)
            {
                for (int j = 0; j< a.Columns; j++)
                {
                    result[i, j] = a[i, j] - b[i,j];
                }
            }
            return result;
        }


        public static Matrix operator *(Matrix a, Matrix b)
        // Matrix Multiplication 
        {
            if ((a.Columns != b.Rows))
                throw new IndexOutOfRangeException("The matrices have invalid number of rows or columns for multiplication operation");
            int sum;
            Matrix result = new Matrix(new int[a.Rows, b.Columns]);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Columns; j++)
                {
                    sum = 0;
                    for (int k = 0; k < a.Columns; k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }


        public static Matrix operator *(int b, Matrix a)
        // Matrix Multiplication by a single number
        {
            Matrix result = new Matrix(new int[a.Rows, a.Columns]);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i,j] * b;
                }
            }
            return result;
        }


        public static Matrix operator *(Matrix a, int b)
        // Matrix Multiplication by a single number
        {
            Matrix result = new Matrix(new int[a.Rows, a.Columns]);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] * b;
                }
            }
            return result;
        }


        public void Print()
        {
            Console.WriteLine(Rows+" x "+Columns);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(" " + this[i, j]);
                }
                Console.WriteLine();
            }
        }


        public int this[int i, int j]
        {
            // Sets or gets the matrix's element
            get
            {
                if ((i < 0) || (j < 0) || (i >= Rows) || (j >= Columns))
                    throw new IndexOutOfRangeException("The index is out of range");
                return _matrix2D[i, j];
            }

            set
            {
                if ((i < 0) || (j < 0) || (i >= Rows) || (j >= Columns))
                    throw new IndexOutOfRangeException("The index is out of range");
                _matrix2D[i, j] = value;
            }
        }

        public int Rows
        {
            // Returns the number of rows
            get
            {
                return _matrix2D.GetLength(0);
            }            
        }

        public int Columns
        {
            // Returns the number of columns
            get
            {
                return _matrix2D.GetLength(1);
            }            
        }
    }
}
