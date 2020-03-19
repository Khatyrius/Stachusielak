using System;

namespace Zadanie1
{
    class Program
    {
        static int change;
        static void Main(string[] args)
        {
            Console.WriteLine("1 = English || 2 = Polski");
            change = int.Parse(Console.ReadLine());

            while (true)
            {
                switch (change)
                {
                    case 1:
                        Console.WriteLine("Hello World!");
                        break;
                    case 2:
                        Console.WriteLine("Witaj Swiecie!");
                        break;
                }
                change = int.Parse(Console.ReadLine());
            }
        }
    }
}
