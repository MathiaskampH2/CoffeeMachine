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
    /// the method CreateHotDrinkMaker creates the CoffeMachine
    /// </summary>
    public class CoffeeMachineMaker
    {

        public HotDrinkMaker CreateHotDrinkMaker(int userinput,double GetWaterFromUser)
        {
            switch (userinput)
            {
                case 1:
                    return new CoffeeMachine(GetWaterFromUser);

                default:
                    return null;

            }
        }
    }
}