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
            Random random = new Random();
            int randomNumberMin = 0;
            int randomNumberMax = 99999;
            int value = random.Next(randomNumberMin, randomNumberMax);
            string exitCommand = "exit";
            Console.WriteLine($"случайная генерация числе, когда надоест введите {exitCommand} ");
            Console.WriteLine($"например {value}, можете попробовать угадать следующее число ");
            string userUnput = Console.ReadLine();

            while (exitCommand != userUnput)
            {
                if (exitCommand == userUnput)
                {
                    Console.WriteLine("Выход");
                }
                else
                {
                    value = random.Next(randomNumberMin, randomNumberMax);
                    Console.WriteLine(value);
                    Console.WriteLine("Какое число будет следующим? ");
                    userUnput = Console.ReadLine();
                }
            }
        }
    }
    
}
