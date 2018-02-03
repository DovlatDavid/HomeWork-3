using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Գտնել երեք թվերից մեծագույնը։

            Console.WriteLine("-=First Number=-");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("-=Sexond Number=-");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("-=Third Number=-");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine($"-=Max Number is {a}=-");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine($"-=Max Number is {b}=-");
            }
            else
            {
                Console.WriteLine($"-=Max Number is {c}=-");
            }
        }
    }
}
