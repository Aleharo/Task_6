using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] a1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            //int[,] a2 = { { 7, 8 }, { 9, 10 }, { 11, 12 } };

            //int[,] a1 = { { 3, 4, 2 } };
            //int[,] a2 = { { 13, 9, 7, 15 }, { 8, 7, 4, 6 }, { 6, 4, 0, 3 } };

            int[,] a1 = { { 1, 2 }, { 3, 4 } };
            int[,] a2 = { { 2, 0 }, { 1, 2 } };

            //int[,] a1 = { { 1, 0, -2 }, { 0, 3, -1 } };
            //int[,] a2 = { { 0, 3 }, { -2, -1 }, { 0, 4 } };

            Matrix.Matrix a = new Matrix.Matrix(a1);
            Matrix.Matrix b = new Matrix.Matrix(a2);

            a.Print();
            b.Print();
            try
            {
                a[0, 3] = 0;                
                a.Print();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {               
                a = a + b;
                a.Print();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                a = a - b;
                a.Print();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Matrix.Matrix aa = a * b;
                aa.Print();

                a = 2 * a;
                a.Print();
            }

            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
