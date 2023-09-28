using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace homeWork2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int valeu = rand.Next(1, 1000);
            Console.WriteLine("случайная генерация числе, когда надоест введите exit ");
            Console.WriteLine($"например {valeu}, можете попробовать угадать следующее число ");
            string userUnput = Console.ReadLine();
            string exit =  "exit";

            while (exit != userUnput)
                if (exit == userUnput)
                {
                    Console.WriteLine(exit);
                    break;
                }
                else
                {
                    valeu = rand.Next(1, 1000);
                    Console.WriteLine(valeu);
                    Console.WriteLine("Какое число будет следующим? ");
                    userUnput = Console.ReadLine();
                }
        }
    }
    
}
