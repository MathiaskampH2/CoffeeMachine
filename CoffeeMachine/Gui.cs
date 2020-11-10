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
        public void PrintProductUi()
        {
            Console.WriteLine("Please choose what type of product you are using");
            Console.WriteLine("1. Whole Beans");
            Console.WriteLine("2. Ground Beans");
            Console.WriteLine("3. Capsules");
        }
    }
}