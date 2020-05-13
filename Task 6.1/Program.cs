using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размерность массива:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] mass = new int[n];
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    mass[i] = r.Next(-50, 50);
                    Console.Write(mass[i] + " ");
                }
                Console.WriteLine();
                for (int i = 1; i < n; i = i + 2)
                {
                    if (mass[i] > 0)
                    {
                        Console.Write(mass[i] + " ");
                    }
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
            Console.ReadKey();
        }
    }
}
