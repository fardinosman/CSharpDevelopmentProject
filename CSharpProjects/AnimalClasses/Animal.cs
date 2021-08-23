using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    public abstract class Animal
    {
        Boolean IsAlive { get; set; }
        int Weight { get; set; }
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }
        public Animal(bool isalive,int w)
        {
            IsAlive = isalive;
            Weight = w;
            Console.WriteLine("Animal constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal says 'hello'");
        }
        public void Talk()
        {
            Console.WriteLine("Animal is talking");
        }
        public void Sing()
        {
            Console.WriteLine("Animal is singing");
        }
        public string ToString()
        {
            return "status: " + IsAlive + " weight: " + Weight;
        }
    }
}
