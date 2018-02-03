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
            //Ներմուծեք ամսվան համապատասխան թիվը (3>մարտ), արտածեք ամսվա անունը և քանի օր կա այդ ամսում՝  9>սեպտեմբեր 30
            Console.WriteLine("-=Number of Month=-");
            int numb = int.Parse(Console.ReadLine());

            switch (numb)
            {
                case 1:
                    Console.WriteLine("It's name is January and It have 31 days");
                    break;
                case 2:
                    Console.WriteLine("It's name is February and It have 28 or 29 days");
                    break;
                case 3:
                    Console.WriteLine("It's name is March and It have 31 days");
                    break;
                case 4:
                    Console.WriteLine("It's name is April and It have 30 days");
                    break;
                case 5:
                    Console.WriteLine("It's name is May and It have 31 days");
                    break;
                case 6:
                    Console.WriteLine("It's name is June and It have 30 days");
                    break;
                case 7:
                    Console.WriteLine("It's name is July and It have 31 days");
                    break;
                case 8:
                    Console.WriteLine("It's name is August and It have 31 days");
                    break;
                case 9:
                    Console.WriteLine("It's name is September and It have 30 days");
                    break;
                case 10:
                    Console.WriteLine("It's name is October and It have 31 days");
                    break;
                case 11:
                    Console.WriteLine("It's name is November and It have 30 days");
                    break;  
                case 12:
                    Console.WriteLine("It's name is December and It have 31 days");
                    break;
            }
        }
    }
}
