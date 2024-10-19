using MouldLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouldConsoleApp
{
    public class Statue : Mould
    {
        // Constructor
        public Statue(string color, int price) : base(color, price)
        {
        }

        // Overridden method to get the price
        public new int GetPrice()
        {
            return price * 2; // Example: statue price is double the mould price
        }

        // Overridden method to get the color
        public new string ReadColor()
        {
            return $"The statue's color is: {color}";
        }

        // Shadowing method to set/get the size specifically for Statue
        public new static void SetSize(int newSize)
        {
            Mould.SetSize(newSize);
        }

        public new static int GetSize()
        {
            return Mould.GetSize();
        }
    }

}
