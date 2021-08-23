using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary2
{
   public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public bool IsNew { get; set; }

        public Car()
        {
            Make = "nothing yet";
            Color = "Nothing yet";
            IsNew = true;
            Model = "Nothing yet";
            Price = 0.00M;
        }

        public Car(string a, string b , decimal c,bool d, string color)
        {
            Make = a;
            Model = b;
            Price = c;
            IsNew = d;
            Color = color;
        }
        override public string ToString()
        {
            return "Car Make:" + Make+  "Car Model:"+ Model+ "Car Price:"+ Price + "Color: "+ Color+  "IsNew: "+ IsNew;
        }
    }
}
