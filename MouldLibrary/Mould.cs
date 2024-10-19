using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouldLibrary
{
    public class Mould
    {
        // Protected instance variable
        protected string color;

        // Public instance variable
        public int price;

        // Private shared (static) variable
        private static int size;

        // Constructor
        public Mould(string color, int price)
        {
            this.color = color;
            this.price = price;
        }

        // Public method to set the size
        public static void SetSize(int newSize)
        {
            size = newSize;
        }

        // Public method to get the size
        public static int GetSize()
        {
            return size;
        }

        // Public method to get the price
        public int GetPrice()
        {
            return price;
        }

        // Public method to read the color
        public string ReadColor()
        {
            return color;
        }
    }

}
