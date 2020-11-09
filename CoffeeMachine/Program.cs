using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CoffeeMachine;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Gui gui = new Gui();

            gui.PrintMachineChoices();
            
            CoffeeMachine coffeeMachine = new CoffeeMachine(1000,500);

            bool start = false;

            while (!start)
            {
                int userChooseMachine = int.Parse(Console.ReadLine());
                int chosenMachine = userChooseMachine;
                switch (userChooseMachine)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("You have chosen Coffee Machine ");
                        Console.WriteLine($"The Coffee machine has a water level of : {coffeeMachine.WaterContainer} Ml" );
                        Console.WriteLine($"And a product level of : {coffeeMachine.ProductContainer} Gram");
                        Thread.Sleep(5000);
                        Console.Clear();
                        Console.WriteLine("information of your cup of filter Coffee :");
                        Console.WriteLine("it is brewed on :");
                        Console.WriteLine(coffeeMachine.MakeDrink(userChooseMachine).ToString());

                        break;
                }
            }
        }
    }
}