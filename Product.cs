using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDogColor
{
    class Product
    {
        static int _pID;
        static double _price;
        static Product()
        {
            _pID = 10;
            _price = 156.32;
        }
        public static void Display()
        {
            Console.WriteLine("Product ID: " + _pID);
            Console.WriteLine("Product price: " + _price);
        }
    }
    class Medicine
    {
        static void Main(string[] args)
        {
            Product.Display();
        }
    }
}
