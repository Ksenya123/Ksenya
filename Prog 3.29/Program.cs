using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_3._29
{
    class Program
    {
        enum SimpleColor
        {
            Black,
            White,
            Gray,
            Red,
            Orange,
            Yellow,
            Green,
            Blue
        }
        static string InputValid(string text)
        {
            Console.Write("{0} = ", text);
            String num = Console.ReadLine();
            string x = num;
            double x1;
            bool n = Double.TryParse(x, out x1); //Если это число, то переменной num будет присвое число, если нет, то m возратит false, а num будет присвоено 0
            if (n)
            {
                if (x1 >= -10 && x1 <= 10)
                {
                    string m = "" + x1 + "";
                    return m;
                }
                else
                {
                    return "error";
                }
            }
            else
            {
                return "error";
            }
        }
        // проверяет, находится ли точка (x, y)
        // справа от пораболы x = a * (y - y0) ^ 2 + x0
        static bool IsPointRightOfParabolaX(double x, double y, double x0, double y0, double a)
        {
            return x < a * ((y - y0) * (y - y0)) + x0;
        }

        // проверяет, находится ли точка (x, y)
        // выше линии y = a * (x - x0) + y0
        static bool IsPointAboveLine(double x, double y,//Справа True слева False
                double x0, double y0, double a)
        {
            return y > a * (x - x0) + y0;
        }
        static SimpleColor GetColor(double x, double y)
        {
            bool a = IsPointRightOfParabolaX(x, y, -1, -3, -0.25); //Парабола влево
            bool b = IsPointAboveLine(x, y, -7, 2, -2.5); //Линия наискосок
            bool c = IsPointAboveLine(x, y, 1, -5, 0); //Линия горизонтальная
            if (a && !b)
            {
                return SimpleColor.Gray;
            }
            if ((a && b && c) || (b && !a && !c))
            {
                return SimpleColor.Orange;
            }
            if ((a && b && !c)||(!a && b && c))
            {
                return SimpleColor.Green;
            }
            if(!a && !b)
            {
                return SimpleColor.Yellow;
            }
                return SimpleColor.White;
        }
        static void PrintColorForPoint(double x, double y)
        {
            Console.WriteLine("({0}, {1}) -> {2}", x, y, GetColor(x, y));
        }
        static void Main(string[] args)
        {
            PrintColorForPoint(-4, 0);//Orange
            PrintColorForPoint(-4, -8);//Yellow
            PrintColorForPoint(-6, -3);//Gray
            PrintColorForPoint(2, 2);//Green
            while (true)
            {
                try
                {
                    double x = double.Parse(InputValid("Input X"));
                    double y = double.Parse(InputValid("Input Y"));
                    Console.WriteLine("({0}, {1}) -> {2}", x, y, GetColor(x, y));
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите координаты не больше 10 и не меньше -10;");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }
        }
    }
}
