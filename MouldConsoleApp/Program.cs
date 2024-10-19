using MouldLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Mould object
            Mould mould = new Mould("Red", 500);
            Console.WriteLine($"Mould Color: {mould.ReadColor()}");
            Console.WriteLine($"Mould Price: {mould.GetPrice()}");

            // Set and get size (static/shared variable)
            Mould.SetSize(10);
            Console.WriteLine($"Mould Size: {Mould.GetSize()}");

            // Create a Statue object (derived class)
            Statue statue = new Statue("Blue", 700);
            Console.WriteLine(statue.ReadColor());
            Console.WriteLine($"Statue Price: {statue.GetPrice()}");

            // Shadowing method to set and get size for Statue
            Statue.SetSize(20);
            Console.WriteLine($"Statue Size: {Statue.GetSize()}");
        }
    }

}
