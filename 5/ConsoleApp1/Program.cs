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
            Console.WriteLine("-=Please give me a number=-");
            int myInt = int.Parse(Console.ReadLine());

            if (myInt % 2 == 0)
            {
                Console.WriteLine("-=Tivy zuyg e!=-");
            }
            else
            {
                Console.WriteLine("-=Tivy kent e!=-");
            }
        }
    }
}
