using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Multidimesnional array
            /* int[] -1D array-{1,2,3}
             * int[,]->2D->rows and columns array-->{{1,2},
             *                                       {3,4}
             * int [,,]-> 3D array(cube)
             *           * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             */

            int[,] sales = new int[5, 3]
                {
                    {120,90,30 },//Stand1:Vanilla,Choclate, Strawberry
                    {121,91,30 },
                    {122,92,30 },
                    {123,93,30 },
                    {124,94,30 }

                };

            for (int i = 0; i < 5; i++)
            {
                Console.Write($" Stand{i + 1}: ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sales[i, j] + " ");
                }
                Console.WriteLine();
            }
            //3-D Arrays


            //int[,,] data = new int[x(layer/depth), y(row), z(column)];

            int[,,] sales2 = new int[2, 5, 3]
            {
                {//Day 1
                    {120,90,60 },
                    {120,90,60 },
                    {120,90,60 },
                    {120,90,60 },
                    {120,90,60 },

                },

                {//Day 2
                    {120,90,60 },
                    {120,90,60 },
                    {120,90,60 },
                    {120,90,60 },
                    {120,90,60 },
                },


            };

            //Jagged Arrays:beacuse the rows (inner arrays) can have different length

            int[][] jaggedSales = new int[5][];
            jaggedSales[0] = new int[] { 120, 90 };
            jaggedSales[1] = new int[] { 120, 90, 75 };
            jaggedSales[2] = new int[] { 30 };
            jaggedSales[3] = new int[] { 120, 90, 75 };
            jaggedSales[4] = new int[] { 120, 90, 75 };
            for (int i = 0; i < jaggedSales.Length; i++)
            {
                Console.Write($" Stand{i + 1}: ");

                for (int j = 0; j < jaggedSales[i].Length; j++)
                {
                    Console.Write(jaggedSales[i][j] + " ");
                }
                Console.WriteLine();
            }


            //List in Csharp
            //List<....>
            //List<int>

            List<List<int>> standSales = new List<List<int>>()

            {
                    new List<int> { 120, 90, 80 },
                    new List<int> { 121, 91, 80 },
                    new List<int> { 75 },
                    new List<int> { 120, 90, 80, 50, 70 },
                    new List<int> { 120, 90, 80 },
                }
            ;
            for (int i = 0; i < standSales.Count; i++)
            {
                Console.Write($" Stand{i + 1}: ");

                foreach (int sale in standSales[i])
                {
                    Console.Write(sale + " ");
                }
                Console.WriteLine();
            }

            standSales.Add(new List<int> { 10, 10 });
            Console.WriteLine($" Added a new stand: {standSales.Count}");



            ////Printing upside down triangle
            //int[][] jagged = new int[3][];
            //jagged[0] = new int[] { 1, 2, 3 };
            //jagged[1] = new int[] { 4, 5 };
            //jagged[2] = new int[] { 6 };
            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    Console.Write($"Row{i + 1}: ");
            //    for (int j = 0; j < jagged[i].Length; j++)
            //    {
            //        Console.Write(jagged[i][j] + " ");
            //    }
            //    Console.WriteLine();

            //}
        }
    }
}
