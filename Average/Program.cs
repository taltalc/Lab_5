using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Mass = new double[7];
            Mass[0] = Convert.ToDouble(Console.ReadLine());
            Mass[1] = Convert.ToDouble(Console.ReadLine());
            Mass[2] = Convert.ToDouble(Console.ReadLine());
            Mass[3] = Convert.ToDouble(Console.ReadLine());
            Mass[4] = Convert.ToDouble(Console.ReadLine());
            Mass[5] = Convert.ToDouble(Console.ReadLine());
            Mass[6] = Convert.ToDouble(Console.ReadLine());
            double Sum = 0;
            for (int i = 0; i < 7; i++)
            {
                Sum += Mass[i];
            }
            Console.WriteLine("Среднее арифметическое {0,4:f2}", Sum / 7);
            Console.ReadKey();

        }

    }
}
