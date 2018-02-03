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
            //Ներմուծեք տաքսու անցած ճանապարհը, արտածեք քանի դրամ արժի երթը
            Console.WriteLine("-=Road in km=-");
            int r = int.Parse(Console.ReadLine());

            if (r <= 4)
            {
                Console.WriteLine("It costs -  500 AMD");
            }
            else
            {
                Console.WriteLine($"It costs - {500 + ((r - 4) * 100)} AMD");
            }
        }
    }
}
