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
            //Ներմուծեք շաբաթվա օրերին համապատասխան թիվը, արտածեք համապատասխան օրը՝ 2>երեքշաբթի
            Console.WriteLine("-=Number for WeekDay=-");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Erkushabti");
                    break;
                case 2:
                    Console.WriteLine("Ereqshabt");
                    break;
                case 3:
                    Console.WriteLine("Choreqshabti");
                    break;
                case 4:
                    Console.WriteLine("Hingshabt");
                    break;
                case 5:
                    Console.WriteLine("Urbat");
                    break;
                case 6:
                    Console.WriteLine("Shabat");
                    break;
                case 7:
                    Console.WriteLine("Kiraki");
                    break;
            }
        }
        }


        }
   
