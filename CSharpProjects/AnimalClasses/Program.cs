using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal beast = new Animal(true,100);
            //beast.Greet();
            //beast.Talk();
            //beast.Sing();
            

            //Console.WriteLine(beast.ToString());


            Dog d = new Dog(false, 25);
            d.Sing();
            d.Talk();
            d.Fetch("Stick");
            d.TouchME();
            d.FeedMe();
            Console.WriteLine(d.ToString());

            Robin robin = new Robin();
            robin.Sing();
            robin.Talk();

            Cow cow = new Cow(true, 25);
            cow.Milking();
            cow.Talk();

            Console.ReadLine();
        }
    }
}
