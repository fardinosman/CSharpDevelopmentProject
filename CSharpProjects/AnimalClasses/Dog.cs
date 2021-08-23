using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
  public class Dog :Animal,IDomesticated
    {
        public Dog(bool isalive, int w) : base(isalive, w)
        {
        }

        public void Talk()
        {
            Console.WriteLine("Barking");
        }
        public void Sing()
        {
            Console.WriteLine("Awwwuuu");
        }
        public void Fetch(string thing)
        {
            Console.WriteLine("Here you go.ere is you "+ thing + " that was fun let's do it again ");
        }

        public void TouchME()
        {
            Console.WriteLine("Please scratch behind my ears");
        }

        public void FeedMe()
        {
            Console.WriteLine("Suppertime! the ver best time of day");
        }
    }
}
