using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._29
{
    class Program
    {
        static double ReadX()
        {
            Console.Write("X = ");
            return double.Parse(Console.ReadLine());
        }
        static double ReadY()
        {
            Console.Write("Y = ");
            return double.Parse(Console.ReadLine());
        }
        static bool CheckPoints(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double k = (y2 + y1) / (x2 + x1);
            double m = k * x1 - y1;
            return y3 == k * x3 + m;
        }
        static bool Equilateral(double a, double b, double c)
        {
            return (a == b & b == c & c == a);
        }
        static bool Isosceles(double a, double b, double c)
        {
            return (a == b || b == c || c == a);
        }
        static bool Versatile(double a, double b, double c)
        {
            return (a != b & b != c & c != a);
        }
        static bool Rectangular(double a, double b, double c)
        {
            return (a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b);
        }
        static bool Obtuse(double a, double b, double c)
        {
            return (a * a + b * b >= c * c || b * b + c * c >= a * a || a * a + c * c >= b * b);
        }
        static bool AcuteAngled(double a, double b, double c)
        {
            return (a * a + b * b <= c * c || b * b + c * c <= a * a || a * a + c * c <= b * b);
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты 1 точки:");
            double x1 = ReadX();
            double y1 = ReadY();
            Console.WriteLine("Введите координаты 2 точки:");
            double x2 = ReadX();
            double y2 = ReadY();
            Console.WriteLine("Введите координаты 3 точки:");
            double x3 = ReadX();
            double y3 = ReadY();


            // равносторонний, равнобедренный, разносторонний, прямоугольный, тупоугольный, остроугольный

            if (!CheckPoints(x1,y1,x2,y2,x3,y3))
            {
                double a = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
                double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

                //Console.Write("a = {0}, b = {1}, c = {2}", a, b, c);

                if (Equilateral(a,b,c))
                {
                    Console.Write("Треугольник равносторонний."); 
                }
                else if (Isosceles(a,b,c))
                {
                    Console.Write("Треугольник равнобедренный."); 
                }
                else if (Versatile(a, b, c))
                {
                    Console.Write("Треугольник разносторонний.");
                }

                if (Rectangular(a, b, c))
                {
                    Console.Write("Тpеугольник прямоугольный.");
                } else if (Obtuse(a, b, c))
                {
                    Console.Write("Тpеугольник тупоугольный.");
                } else if (AcuteAngled(a, b, c))
                {
                    Console.Write("Тpеугольник остроугольный.");
                }

            }
            else
            {
                Console.WriteLine("Треугольник не существует.");
            }
            Console.ReadKey();
        }
    }
}
