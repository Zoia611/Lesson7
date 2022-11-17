using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void GetParamsKube(double a, out double s, out double v)
        {
            s = 6 * a * a;
            v = a * a * a;
        }
        static void Main(string[] args)         
        {
            Console.WriteLine("Введите длинну ребра");
            double a = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetParamsKube(a, out s, out v);
            Console.WriteLine("{0} {1}",s,v);
            Console.ReadLine();

        }
    }
}
