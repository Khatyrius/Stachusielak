using System;
using System.IO;
using System.Reflection;

//Rozwiązanie dynamiczne
namespace Zadanie5b
{
    class Program
    {
        static void Main(string[] args)
        {
            var dllPath = new FileInfo(@"C:\Users\barto\source\repos\Stachusielak_DOTNET\Lista1\Zadanie5DllLibrary\bin\Debug\netcoreapp3.1\Zadanie5DllLibrary.dll");
            var myDll = Assembly.LoadFile(dllPath.FullName);
            var classType = myDll.GetType("Zadanie5DllLibrary.Calculate");
            object loadedDll = Activator.CreateInstance(classType);

            MethodInfo[] methods = classType.GetMethods();
            
            Console.WriteLine("Podaj dwie liczby");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            object sumResult = methods[0].Invoke(myDll, new object[] {a, b});
            object subResult = methods[1].Invoke(myDll, new object[] { a, b });
            object mulResult = methods[2].Invoke(myDll, new object[] { a, b });
            object divResult = methods[3].Invoke(myDll, new object[] { a, b });

            Console.WriteLine("Dodawanie: " + sumResult.ToString());
            Console.WriteLine("Odejmowanie: " + subResult.ToString());
            Console.WriteLine("Mnozenie: " + mulResult.ToString());
            Console.WriteLine("Dzielenie: " + divResult.ToString());

        }
    }
}
