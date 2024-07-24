using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    public class Dog
    {
        public string Name;
        public string Food;
        public float Height;
        public float Weight;

        public Dog() { }
        public Dog(string name, string food, float height, float weight)
        {
            Name = name;
            Food = food;
            Height = height;
            Weight = weight;

        }
        public void Run()
        {
            Console.WriteLine("the" + Name + "is runing");
        }
        public void Size(float y, float x)
        {
            Weight = y;
            Height = x;
            Console.WriteLine("Weight of " + Name + " is: " + Weight + " and Height is: " + Height);
        }
        public void Foody()
        {
            Console.WriteLine("the food of " + Name + ": is " + Food);
        }
        public string Ditails()   
        {
            return (Name + Weight + Height + Food);
        }
       

        
        
    }
}
