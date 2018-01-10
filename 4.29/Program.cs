using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static bool func(int x)
        {
            int y = x, k = 0, m = 0;

            while (y >= 1)         
            {

                if (y % 2 == 0)    
                { k++; }             
                else             
                { m++; }
                y = y / 10;       
            }
            return (m == k);      
        }                      

        static int sum(int a, int b) 
        {
            int sum = 0;
            for (int i = a; i <= b; i++) 
            {
                if (func(i))      
                    sum += i;     
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int a, b;
            for (; ; )
            {
                try
                {
                    Console.WriteLine("Введите А: ");
                    a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите B: ");
                    b = Int32.Parse(Console.ReadLine());

                    int res = sum(a, b);                      

                    Console.WriteLine("Сумма равна: " + res);   
                }
                catch (FormatException exception)
                {
                    Console.WriteLine("Вы ввели буквы,повторите ввод");
                }
            }
        }
    }
}

