using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._29
{
    class Program
    {
        static double Readch()
        {
            return double.Parse(Console.ReadLine());
        }

        static double WritAP(double a, double b, double c)
        {
            return (a / (a + b - c)) * 100;
        }
        static double WritBP(double a, double b, double c)
        {
            return (b / (a + b - c)) * 100;
        }
        static double WritCP(double a, double b, double c)
        {
            return (c / (a + b - c)) * 100;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число A = ");
            double a = Readch();
            Console.Write("Введите число B = ");
            double b = Readch();
            Console.Write("Введите число C = ");
            double c = Readch();

            Console.Write(    "Процент A = {0}%, B = {1}%, C = {2}%",WritAP(a,b,c),WritBP(a,b,c),WritCP(a,b,c)       );
            Console.ReadKey();

        }
    }
}
