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
            //Պարզել ներմուծված թիվը արդյոք բաժանվու՞մ է առանց մնացորդի 5-ի վրա։

            Console.WriteLine("-=Please give me a number=-");
            int myInt = int.Parse(Console.ReadLine());

            if (myInt % 5 == 0)
            {
                Console.WriteLine("-=YES=-");
            }
            else
            {
                Console.WriteLine("-=NO=-");
            }
        }
    }
}
