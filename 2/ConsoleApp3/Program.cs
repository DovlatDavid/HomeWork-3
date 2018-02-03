using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Գտնել երեք թվերից փոքրագույնը։

            Console.WriteLine("-=First Number=-");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("-=Sexond Number=-");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("-=Third Number=-");
            int c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine($"-=Min Number is {a}=-");
            }
            else if (b < c && b < a)
            {
                Console.WriteLine($"-=Min Number is {b}=-");
            }
            else
            {
                Console.WriteLine($"-=Min Number is {a}=-");
            }
        }
    }
}
