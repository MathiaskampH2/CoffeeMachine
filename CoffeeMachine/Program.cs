﻿using System;
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

            BrewingUnit brewingUnit = new BrewingUnit();

            bool start = false;

            while (!start)
            {
                int userChooseMachine = int.Parse(Console.ReadLine());
                switch (userChooseMachine)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("You have chosen Coffee Machine ");
                        Console.WriteLine("How much water do you want to put in the coffee machine : ");
                        double userFillWater = Double.Parse(Console.ReadLine());
                        HotDrinkMaker coffeeMachineDrinkMaker = new CoffeeMachineMaker().CreateHotDrinkMaker(userChooseMachine, userFillWater);
                        Console.Clear();
                        Console.WriteLine("Here is your coffee machine \n " + "it is filled with " + coffeeMachineDrinkMaker.ToString());
                        Thread.Sleep(5000);
                        Console.Clear();
                        gui.PrintCoffeeUi();
                        int userChooseProductForCoffee = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Brewing.....................");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.WriteLine("here is your coffee \n" + "It is brewed on :\n" + brewingUnit.MakeDrink(userChooseMachine, userChooseProductForCoffee).ToString());
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                }

                start = true;
            }
        }
    }
}