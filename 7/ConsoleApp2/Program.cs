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
            //Ներմուծված թիվը բազմապատկել 2-ով, եթե այն զու՞յգ է և առանց մնացորդի բաժանվու՞մ է 3-ի վրա։

            Console.WriteLine("-=Please, give me a number=-");
            int myInt = int.Parse(Console.ReadLine());

            if (myInt % 6 == 0)
            {
                Console.WriteLine(myInt*2);
            }
        }
    }
}
