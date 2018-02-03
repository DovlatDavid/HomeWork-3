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
            //Տրված է եռանիշ թիվ, հաշվել և արտածել եռանիշ թվի և իր թվանշանների գումարի հարաբերությանն արժեքը։

            Console.WriteLine("-=Greq Eranish tiv=-");
            int x = int.Parse(Console.ReadLine());
            int a = x % 10;
            int b = ((x % 100) - a);
            int c = ((x % 1000) - a - b) / 100;
            int res1 = a + (b / 10) + c;
            int res = x / res1;

            Console.WriteLine($"Answer is - {res}");
        }
    }
}
