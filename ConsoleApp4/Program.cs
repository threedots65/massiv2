using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max;
            Random r = new Random();
            int[,] arr = new int[3, 3] 
            { {r.Next(0,100), r.Next(0, 100), r.Next(0, 100) },
            { r.Next(0, 100), r.Next(0, 100), r.Next(0, 100) },
            { r.Next(0, 100), r.Next(0, 100), r.Next(0, 100) }};

            for (int i = 0;i<3;i++)
            {
                for (int j = 0;j<3;j++)
                {
                    Console.Write(arr[i,j]+"\t");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            for (int i = 0; i<3;i++)
            {
                max = 0;
                for (int j = 0;j<3;j++)
                {
                    if (max<arr[i,j])
                     max=arr[i,j];
                }
                Console.WriteLine(max);
            }
            Console.ReadKey();


            


        }
    }
}
