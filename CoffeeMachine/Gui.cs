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
    }
}