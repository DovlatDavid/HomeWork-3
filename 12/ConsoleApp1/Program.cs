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
            //Ներմուծեք թիվ ու ասեք՝ արդյոք այ թիվը միանիշ է, երկնիշ, եռանիշ, քառանիշ կամ այլ
            Console.WriteLine("-=Please, give me a number=-");
            int num = int.Parse(Console.ReadLine());

            if (num < 10)
            {
                Console.WriteLine("Mianish");
            }
            else if (num < 100 & num > 9)
            {
                Console.WriteLine("Erknish");
            }
            else if (num < 1000 & num >99)
            {
                Console.WriteLine("Eranish");
            }
            else if (num <10000 & num > 999)
            {
                Console.WriteLine("Qaranish");
            }
        }
    }
}
