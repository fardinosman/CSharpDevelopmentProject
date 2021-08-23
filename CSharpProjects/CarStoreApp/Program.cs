using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();
            Console.WriteLine("Welcome to the car store. First you must create som car inventory. Then you may add some cars to the shopping cart. finally you may checkout which will give you a total value of the shopping cart." );
            int action = chooseAction();
            while (action !=0)
            {
                Console.WriteLine("You chose " + action);
                action = chooseAction();
                switch (action)
                {
                    //add item to inventory
                    case 1:
                        Console.WriteLine("You choose to add a new Car to the inventory");
                        String carMake = "";
                        String carModel = "";
                        Decimal carPrice = 0;
                        Boolean isNew = false;
                        String color = "";
                        Console.WriteLine("What is the car make? ford, gm, nissan etc.");
                        carMake = Console.ReadLine();
                        Console.WriteLine("What is the car Model ? corvette, focus, ranger etc.");
                        carModel = Console.ReadLine();
                        Console.WriteLine("What is the car price?");
                        carPrice = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is the color? ");
                        color = Console.ReadLine();
                        Console.WriteLine("Is it a new Car? ");
                        isNew = bool.Parse(Console.ReadLine());
                        Car newCar = new Car(carMake, carModel, carPrice,isNew,color);
                        s.CarList.Add(newCar);
                        printInventory(s);
                        break;
                    case 2:
                        Console.WriteLine("You choose to add a car to your shopping cart");
                        printInventory(s);
                        Console.WriteLine("Which item would you like to choose");
                        int carChosen = int.Parse(Console.ReadLine());
                        s.ShoppingList.Add(s.CarList[carChosen]);
                        printShoppingCart(s);

                        break;
                    case 3:
                        printShoppingCart(s);
                        Console.WriteLine("The total Cost of items" + s.Chechout());
                        break;
                    default:
                        break;
                   
                }
            }

           
        }

        private static void printShoppingCart(Store s)
        {
            Console.WriteLine("Cars you have chosen to buy");   
            for (int i = 0; i < s.ShoppingList.Count; i++)
            {
                Console.WriteLine("Car # " + i + " " + s.ShoppingList[i]);
            }
        }

        private static void printInventory(Store s)
        {
            for( int i =0; i< s.CarList.Count; i++)
            {
                Console.WriteLine("Car # " + i + " " +s.CarList[i]);
            }
        }

        public static int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new car to inventory (2) add car to cart (3) checkout");
           
                
            try
            {

                choice = int.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {

                Console.WriteLine("only integer option beetween 0-3");
                Console.WriteLine("Choose an action (0) to quit (1) to add a new car to inventory (2) add car to cart (3)") ;
                choice = int.Parse(Console.ReadLine());

            }
           


            return choice;
        }
    }
}
