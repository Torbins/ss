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
            System.Console.WriteLine("Hello World!");
            System.Console.WriteLine("Mykola Petrivs'kyi");
            System.Console.WriteLine("Vitalik Dosiak");
            PrintMkosName();
        }
    static void PrintMkosName()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Mykola Kos");
        Console.ResetColor();
    }
}
}
