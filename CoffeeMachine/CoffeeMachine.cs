using System.Security.Cryptography;

namespace CoffeeMachine
{
    public  class CoffeeMachine :HotDrinkMaker, IChooseProduct
    {
        public CoffeeMachine(double waterContainer, double productContainer, int numberOfCups) : base(waterContainer, productContainer, numberOfCups)
        {

        }

        public string[] Products()
        {
            string [] product = new string[]{"Whole Beans", "Ground Beans", "Capsules"};

            return product;
        }

        public override double FillWaterContainer()
        {
            return waterContainer = 1;
        }


        public override double FillProductContainer()
        {
            throw new System.NotImplementedException();
        }

        public override string GetNumberOfCups()
        {
            double fillWaterContainer = FillWaterContainer();
            string numberOfCups = null;

            if (fillWaterContainer == 1)
            {
                numberOfCups = "Number of cups to be made is 5";
            }

            return numberOfCups;
        }
    }
}