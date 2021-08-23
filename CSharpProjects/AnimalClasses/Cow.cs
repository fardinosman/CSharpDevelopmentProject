using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Cow : Animal, IMilkable
    {
        public Cow(bool isalive, int w) : base(isalive, w)
        {
        }

        public void Milking()
        {
            Console.WriteLine("Full Milk");
        }
    }
}
