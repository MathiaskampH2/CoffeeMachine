using System;

namespace CoffeeMachine
{
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
                    return new FilterCoffeeMaker(200, userChoosenProduct, 93);

                default:
                    return null;

            }

        }
    }
}