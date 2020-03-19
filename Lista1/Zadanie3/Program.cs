using System;
using System.IO;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());

                    foreach (DirectoryInfo d in dir.GetDirectories())
                    {
                        Console.WriteLine("{0, -30}\t directory", d.Name);
                    }

                    foreach (FileInfo f in dir.GetFiles())
                    {
                        Console.WriteLine("{0, -30}\t File", f.Name);
                    }
                }

                else if (args.Length == 1)
                {
                    string path = (String)args.GetValue(0);
                    Directory.SetCurrentDirectory(path);
                    DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());

                    foreach (DirectoryInfo d in dir.GetDirectories())
                    {
                        Console.WriteLine("{0, -30}\t directory", d.Name);
                    }

                    foreach (FileInfo f in dir.GetFiles())
                    {
                        Console.WriteLine("{0, -30}\t File", f.Name);
                    }
                }
            }catch(System.IO.DirectoryNotFoundException exception)
            {
                Console.WriteLine("Nie znaleziono podanego katalogu");
            }
        }
    }
}

