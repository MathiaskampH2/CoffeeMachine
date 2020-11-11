using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
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




            public HotDrinkMaker CreateHotDrinkMaker(int userinput,double GetWaterFromUser, double GetProductFromUser)
        {
            //double fillWater = ValidateWaterContainerLevelFromUser(GetWaterFromUser);
            //double fillProduct = ValidateProductLevelFromUser(GetProductFromUser);

            switch (userinput)
            {
                case 1:
                    return new CoffeeMachine(GetWaterFromUser, GetProductFromUser);

                default:
                    return null;

            }
        }
    }
}