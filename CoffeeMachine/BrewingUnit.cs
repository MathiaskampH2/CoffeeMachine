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
        
        
        public string GetProductFromUser(int userinput)

        {
            string saveUserInput = null;

            switch (userinput)

            {
                case 1:
                   saveUserInput = "Whole Beans";

                  
                    break;

                case 2:
                    saveUserInput = "Ground Beans";
                    break;

            }

            return saveUserInput;
        }



        public Drink MakeDrink(int userChoseDrink, int userChooseProduct)

        {
            string userChoosenProduct = GetProductFromUser(userChooseProduct);
            switch (userChoseDrink)
            {
                case 1:
                    return new FilterCoffeeMaker (200, userChoosenProduct, 93);

                default:
                    return null;

            }

        }
    }
}