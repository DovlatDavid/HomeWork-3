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
            //Գրեք տարեթիվը ու պարզեք՝ էդ տարին նահանջ տարի ա, թե չէ
            
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"Year - {year}");

            if (year % 4 == 0)
            {
                Console.WriteLine("Tarin Nahanch e");
            }
            else
            {
                Console.WriteLine("Tarin Nahanch che");
            }
        }
    }
}
