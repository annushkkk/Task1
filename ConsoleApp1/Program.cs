using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            Test(n);
            

        }
        static bool CheckRow(int[] row)
        {
            int prevd = row[1] - row[0];
            int currd;
            for (int i = 2; i < row.Length; i++)
            {
                currd = row[i] - row[i - 1];
                if (prevd!=currd)
                {
                    return false;
                }
                prevd = currd;
                
            }
            return true;
        }
        static int [][] EnterMatrix(int n)
        {
            Console.WriteLine("Введите массив:");
            int[][] matrixn = new int[n][];
            for (int i = 0; i < n; i++)
            {
                string enterString = Console.ReadLine();
                string[] massiveString = enterString.Split(new Char[] { ' ' });
                matrixn[i] = new int[n];
                for (int j = 0; j < massiveString.Length; j++)
                {
                    matrixn[i][j] = int.Parse(massiveString[j]);

                }

            }
            return matrixn;
        }
        static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                foreach(int j in matrix[i])
                {
                    Console.Write(j);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Test(int n)
        {
            int count = 0;
            int[][] matrixn = EnterMatrix(n);
            
            foreach (int[] i in matrixn)
            {
                if (CheckRow(i)) { count++; }
            }
            Console.Write("Число строк с арифметической прогрессией:");
            Console.WriteLine(count);


            count = 0;
            int[][] matrix1 = new int[4][];
            matrix1[0] = new int[] { 1, 3, 5, 7 };
            matrix1[1] = new int[] { 0, 12, 24, 36 };
            matrix1[2] = new int[] { 11, 22, 55, 0 };
            matrix1[3] = new int[] { 55, 33, 55, 33 };
            PrintMatrix(matrix1);

            foreach (int[] i in matrix1)
            {
                if (CheckRow(i)) { count++; }
            }
            Console.Write("Число строк с арифметической прогрессией:");
            Console.WriteLine(count);
            count = 0;

            int[][] matrix2 = new int[3][];
            matrix2[0] = new int[] { 1, 19, 37 };
            matrix2[1] = new int[] { -55, 0, 55 };
            matrix2[2] = new int[] { -1, -2, -3 };
           
            PrintMatrix(matrix2);


            foreach (int[] i in matrix2)
            {
                if (CheckRow(i)) { count++; }
            }
            Console.Write("Число строк с арифметической прогрессией:");
            Console.WriteLine(count);
            count = 0;

        }
        
    }
}
