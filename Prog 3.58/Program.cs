using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_3._58
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
        static bool IsPointInRect(double x, double y, double x0, double y0, double w, double h) //Прямоугольник
        {
            return x < x0 + w && x > x0 && y > y0 - h && y < y0;
        }
        // проверяет, находится ли точка (x, y)
        // внутри круга (x - x0) ^ 2 + (y - y0) ^ 2 = r ^ 2
        static bool IsPointInCircle(double x, double y,
                double x0, double y0, double r)
        {
            return ((x - x0) * (x - x0)) + ((y - y0) * (y - y0)) < r * r;
        }
        static SimpleColor GetColor(double x, double y)
        {
            bool a = IsPointInRect(x, y, -2, 8, 2, 10); //Прямоугольлник
            bool b = IsPointInRect(x, y, -4, 5, 10, 10); //Квадрат
            bool c = IsPointInCircle(x, y, -4, 0, 3); //Большой круг
            bool d = IsPointInCircle(x, y, -4, 0, 2); //Внутренний круг
            bool e = IsPointInCircle(x, y, 1, 5, 2); //Малый круг
            if ((!a && !b && !c && !e) || (!b && d))
            {
                return SimpleColor.Yellow;
            }
            if ((c && !d && !b) || (c && !d && !a && y >= 0) || (b && d))
            {
                return SimpleColor.Blue;
            }
            if ((c && a) || (e && a && !b) || (c && !d && y <= 0))
            {
                return SimpleColor.Gray;
            }
            if ((b && !c && !a && y > 0 && x < 0) || (d && !b && !a))
            {
                return SimpleColor.White;
            }
            if (a && !b && !e)
            {
                return SimpleColor.Green;
            }
            if ((b && !c && y < 2) || (b && !c && x >= -2) || (a && b && !c))
            {
                return SimpleColor.Orange;
            }
            return SimpleColor.White;
        }
        static void PrintColorForPoint(double x, double y)
        {
            Console.WriteLine("({0}, {1}) -> {2}", x, y, GetColor(x, y));
        }
        static void Main(string[] args)
        {
            PrintColorForPoint(2, 2);//Orange
            PrintColorForPoint(-5, 1);//Yellow
            PrintColorForPoint(-1.5, -1);//Gray
            PrintColorForPoint(-1, 7);//Green
            PrintColorForPoint(-3, 1);//Blue
            PrintColorForPoint(-3, 4);//White
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
