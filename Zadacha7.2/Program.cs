using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба:");
            double a = Convert.ToInt32(Console.ReadLine());
            double V, S;
            CubeVnS(a, out V, out S);
            Console.WriteLine("Объем куба с заданной длиной ребра равен {0:f2}.",V);
            Console.WriteLine("Площадь поверхности куба с заданной длиной ребра равна {0:f2}.", S);
            Console.ReadKey();
        }
        static void CubeVnS(double a, out double V, out double S)
        {
            V = a*a*a;
            S = a*a*6;
        }
    }
}
