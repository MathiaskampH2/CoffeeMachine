using System;

namespace CoffeeMachine
{
    /// <summary>
    /// BrewingUnit Class
    /// it is responsible of making the Drink and return it to the user
    /// It has a method that gets what product of coffee the user wants
    /// </summary>
    public class BrewingUnit
    {
        public string GetCoffeeFromUser(int userInput)

        {
            string saveUserInput = null;

            switch (userInput)

            {
                case 1:
                    saveUserInput = "BKI";


                    break;

                case 2:
                    saveUserInput = "Peter Larsen";
                    break;
            }

            return saveUserInput;
        }

        public string GetTeaFromUser(int userInput)
        {
            string saveUserInput = null;
            
            switch (userInput)
            {

                case 1:
                    saveUserInput = "Earl Gray";


                    break;

                case 2:
                    saveUserInput = "Mango";
                    break;


                case 3:
                    saveUserInput = "English Breakfast";


                    break;

                case 4:
                    saveUserInput = "Green Tea";
                    break;

                default:
                    return "enter valid number";
            }

            return saveUserInput;
        }


      
        public Drink MakeDrink(int userChoseDrink, int userChooseProduct)

        {
            string userChosenCoffee = GetCoffeeFromUser(userChooseProduct);
            string userChooseTea = GetTeaFromUser(userChooseProduct);
            switch (userChoseDrink)
            {
                case 1:
                    return new FilterCoffee(name:"Filter Coffee", water:200, userChosenCoffee, temperature:93);

                case 2:
                    return new Tea(name: "Tea", water:250, userChooseTea, temperature:93);
                    
                default:
                    return null;
            }
        }
    }
}