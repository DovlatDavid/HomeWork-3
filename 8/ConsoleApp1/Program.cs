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
            //Ներմուծված թիվը բազմապատկել 2-ով, եթե այն կենտ է կամ առանց մնացորդի բաժանվում է 3-ի վրա։

            Console.WriteLine("-=Please, give me a number=-");
            int myInt = int.Parse(Console.ReadLine());

            if (myInt % 2 !=0 | myInt % 3 ==0)
            {
                Console.WriteLine(myInt*2);
            }
        }
    }
}
