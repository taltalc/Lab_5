using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,]Tyc= new int [N, N];
            int count = 0;
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    count++;
                    Tyc[i, j] = count % 2;
                     Console.Write("{0} ", Tyc[i, j]);

                    


                }Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
