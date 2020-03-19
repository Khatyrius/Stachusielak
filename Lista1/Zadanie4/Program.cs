using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            string oldWord, newWord;
            
            if (args.Length == 2)
            {
                oldWord = args[0];
                newWord = args[1];
                replaceWords(oldWord, newWord);
            }                    
        }

        static void replaceWords(string oldWord, string newWord)
        {
            string tmpLine = Console.ReadLine();
            while(tmpLine != null)
            {
                tmpLine = tmpLine.Replace(oldWord, newWord);
                Console.WriteLine(tmpLine);
                tmpLine = Console.ReadLine();
            }
        }
    }
}
