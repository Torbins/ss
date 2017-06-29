using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void PrintMark()
        {
            Console.WriteLine("Mark Spilnyk");
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            System.Console.WriteLine("Mykola Petrivs'kyi");
            System.Console.WriteLine("Vitalik Dosiak");
            Console.WriteLine("Chumak Kostya");
            PrintMkosName();
            Program.PrintMark();
            Console.ReadKey();
            Name();
            Console.ReadLine();
        }
    static void PrintMkosName()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Mykola Kos");
        Console.ResetColor();
    }
        public static void Name()
        {
            Console.WriteLine("Anna Avramenko");
        }
      
    }
}
