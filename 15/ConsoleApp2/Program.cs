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
            //Տրված է եռանիշ թիվ, արտածել true եթե եռանիշ թվի միավորների թվանշանը հավասար է տասնավորների և հարյուրավորների թվանշանների գումարին, հակառակ դեպքում՝ false։

            Console.WriteLine("-=Greq Eranish tiv=-");
            int x = int.Parse(Console.ReadLine());
            int a = x % 10;
            int b = ((x % 100) - a);
            int c = ((x % 1000)- a - b)/100;


             if ((b/10) + c == a)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
            
        }
    }
}
