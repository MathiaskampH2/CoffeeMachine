using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;

namespace CoffeeMachine
{
    /// <summary>
    /// Gui class
    /// has 2 methods that prints out a gui menu
    /// </summary>
    public class Gui
    {
        public void PrintMachineChoices()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("              Hot Drink Machine              ");
            Console.WriteLine("=============================================");

            Console.WriteLine("1. Coffee machine :");
        }
        public void PrintCoffeeUi()
        {
            Console.WriteLine("Please choose what kind of coffee do you want :");
            Console.WriteLine("1. BKI");
            Console.WriteLine("2. Peter Larsen");
        }

        public void PrintTeaUi()
        {
            Console.WriteLine("Please choose what kind of tea you want :");
            Console.WriteLine("1. Earl Gray");
            Console.WriteLine("2. Mango");
            Console.WriteLine("3. English Breakfast");
            Console.WriteLine("4. Green tea");
        }

        public void PrintDrinks()
        {
            Console.WriteLine("What kind of drink would you like :");
            Console.WriteLine("1. Coffee");
            Console.WriteLine("2. Tea");
            Console.WriteLine("3. Espresso");
        }

        public void PrintEspressoUi()
        {
            Console.WriteLine("1. House Blend");
            Console.WriteLine("2. Arabica Blend");
        }
    }
}