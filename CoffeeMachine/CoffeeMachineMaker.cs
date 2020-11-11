using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace CoffeeMachine
{
    /// <summary>
    /// CoffeeMachineMaker
    /// The responsible of this class is to make an Object of CoffeeMachine class
    /// In order to make the CoffeeMachine "Prefilled" when its returned to the user
    /// </summary>
    public class CoffeeMachineMaker
    {

        public HotDrinkMaker CreateCoffeeMachine(int userInput,double GetWaterFromUser)
        {

            switch (userInput)
            {
                case 1:
                    return new CoffeeMachine(GetWaterFromUser);

                default:
                    return null;

            }
        }
    }
}