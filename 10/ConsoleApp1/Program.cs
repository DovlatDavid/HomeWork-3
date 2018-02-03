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
            //Ներմուծեք ամսաթիվը, արտածեք թե ամսվա որ շաբաթվա օրն է դա՝ 15>3
            Console.WriteLine("-=Day of the Week=-");
            int day = int.Parse(Console.ReadLine());
            int res = day / 7;

            switch (res)
            {
                case 0:
                    Console.WriteLine(res + 1);
                    break;
                case 1:
                    Console.WriteLine(res + 1);
                    break;
                case 2:
                    Console.WriteLine(res + 1);
                    break;
                case 3:
                    Console.WriteLine(res + 1);
                    break;
                case 4:
                    Console.WriteLine(res + 1);
                    break;
            }
        }
    }
}
