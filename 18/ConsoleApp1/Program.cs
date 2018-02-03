using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Տրված է եռանիշ թիվ, հաշվել և արտածել եռանիշ թվի թվանշաններից մեծագույնի/փոքրագույնի արժեքը։

            Console.WriteLine("-=Greq Eranish tiv=-");
            int x = int.Parse(Console.ReadLine());
            int a = x % 10;
            int b = ((x % 100) - a);
            int c = ((x % 1000) - a - b) / 100;
            int b1 = b / 10;

            if (a > b1 && a > c)
            {
                if (b1 > c)
                {
                    Console.WriteLine($"max = {a} and min = {c}");
                }
                else
                {
                    Console.WriteLine($"max = {a} and min = {b1}");
                }
            }
            else if (b1 > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine($"max = {b1} and min = {c}");
                }
                else
                {
                    Console.WriteLine($"max = {b1} and min = {a}");
                }            
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine($"max = {c} and min = {a}");
                }
                else
                {
                    Console.WriteLine($"max = {c} and min = {b}");
                }
            }
        }
    }
}
