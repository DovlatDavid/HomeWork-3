using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Արտածել a, b և c կամայական թվերը աճման կարգով։

            Console.WriteLine("-=First Number=-");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("-=Second Number=-");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("-=Third Number=-");
            int c = int.Parse(Console.ReadLine());

            if (a < b & a < c)
            {
                if (b < c)
                {
                    Console.WriteLine($"{a}, {b}, {c} ");
                }
                else
                {
                    Console.WriteLine($"{a}, {c}, {b} ");
                }


            }
            else if (b < a & b < c)
            {
                if (a < c)
                {
                    Console.WriteLine($"{b}, {a}, {c} ");
                }
                else
                {
                    Console.WriteLine($"{b}, {c}, {a}");
                }
            }
            else
            {
                if (a < b)
                {
                    Console.WriteLine($"{c}, {a}, {b}");
                }
                else
                {
                    Console.WriteLine($"{c}, {b}, {a}");
                }
            }
        }
    }
}
