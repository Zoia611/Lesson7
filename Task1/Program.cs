using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static double Triangle (double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стороны второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            if (Triangle(x1, y1, z1) > Triangle(x2, y2, z2)) 
                Console.WriteLine("Площадь второго прямоугольника больше");
            else if (Triangle(x1, y1, z1) < Triangle(x2, y2, z2))
                Console.WriteLine("Площадь первого прямоугольника больше");
            else
                Console.WriteLine("Площади треугольников равны");
            Console.ReadLine();
        }
    }
}
