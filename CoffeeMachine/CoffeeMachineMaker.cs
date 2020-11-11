using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;

namespace CoffeeMachine
{
    /// <summary>
    /// CoffeeMachineMaker
    /// The responsible of this class is to make an Object of CoffeeMachine class
    /// It has some methods to get the waterContainerLevel and ProductLevel from the user
    /// In order to make the CoffeeMachine "Prefilled" when its returned to the user
    /// </summary>
    public class CoffeeMachineMaker
    {
        public double GetWaterContainerLevelFromUser(double userinput)
        {
            double validateUserInput = userinput;

            return validateUserInput;
        }

        public double GetProductLevelFromUser(double userinput)
        {
            double validateUserInput = userinput;

            return validateUserInput;
        }

        public bool ValidateWaterContainerLevelFromUser(double userinput)
        {
            double validateUserInput = GetWaterContainerLevelFromUser(userinput);

            if (validateUserInput < 1200)
            {
                return true;
            }
            else if (validateUserInput > 1200)
            {
                return false;
            }

            return true;
        }

        public bool ValidateProductLevelFromUser(double userinput)
        {
            double validateUserInput = GetProductLevelFromUser(userinput);

            if (validateUserInput < 500)
            {
                return true;
            }
            else if (validateUserInput > 1200)
            {
                return false;
            }

            return true;
        }

        public double ValidateWaterSucess(bool waterValidate)
        {
            waterValidate = ValidateWaterContainerLevelFromUser();
            if (waterValidate = true)
            {
                return
            }


        }



        public HotDrinkMaker CreateHotDrinkMaker(int userinput,double GetWaterFromUser, double GetProductFromUser)
        {
            string fillWater = ValidateWaterContainerLevelFromUser(GetWaterFromUser);
            string fillProduct = ValidateProductLevelFromUser(GetProductFromUser);

            switch (userinput)
            {
                case 1:
                    return new CoffeeMachine(fillWater, fillProduct);

                default:
                    return null;

            }
        }
    }
}