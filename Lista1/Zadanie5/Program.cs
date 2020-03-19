using System;
using Zadanie5DllLibrary;

//Rozwiązanie statyczne
namespace Zadanie5a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Dodawanie: " + Calculate.add(a, b));
            Console.WriteLine("Odejmowanie: " + Calculate.sub(a, b));
            Console.WriteLine("Mnozenie: " + Calculate.mul(a, b));
            Console.WriteLine("Dzielenie: " + Calculate.div(a, b));
        }
    }
}
