using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDogColor
{
    class Dog
    {
        private int ID;
        private string color;
        private int weight;
        public Dog()
        {

        }

        public Dog(int id, string color, int weight)
        {
            this.ID = id;
            this.color = color;
            this.weight = weight;
        }

        public void Display()
        {
            Console.WriteLine("ID: "+ID +" Color: " +color + " Weight: "+weight);
         
        }
       public void FindColor(string color)
        {
            if(this.color == color)
            {
                this.Display();
            }
        }



    }
}
