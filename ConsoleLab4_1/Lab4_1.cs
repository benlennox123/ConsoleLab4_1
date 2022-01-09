using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            Console.Write("N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            int N2=0;
            if (N>0)
            {
                for (int i=1; i <= N; i++)
                {

                    N2 = N2 + (2*i-1);
                    Console.WriteLine(N2);
                }
            }
            else
            {
                Console.WriteLine("Введённое число должно быть >0");
            }
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
