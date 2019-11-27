using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDogColor
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] d = new Dog[10];
            d[0] = new Dog(1, "Brown", 30);
            d[1] = new Dog(2, "white ", 31);
            d[2] = new Dog(3, "yellow", 43);
            d[3] = new Dog(4, "yellow", 52);
            d[4] = new Dog(5, "white", 37);
            d[5] = new Dog(6, "black", 33);
            d[6] = new Dog(7, "Brown", 31);
            d[7] = new Dog(8, "dark", 31);
            d[8] = new Dog(9, "Grey", 23);
            d[9] = new Dog(10, "Grey", 13);
            Console.WriteLine("Which color do u want to find ?? ");
            string color = Console.ReadLine();
            Console.WriteLine("List:  "+color);
            
            for (int i = 0; i < d.Length; i++)
            {
                d[i].FindColor( color);
            }
            Console.ReadLine();
        }
    }
}
