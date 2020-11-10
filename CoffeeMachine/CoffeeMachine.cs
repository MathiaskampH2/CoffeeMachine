
using System.Data;
using System.Text;

namespace CoffeeMachine
{
    public  class CoffeeMachine :HotDrinkMaker
    {


        public CoffeeMachine(double waterContainer, double productContainer) : base(waterContainer, productContainer)
        {

        }

        private double waterContainerMax;

        public double WaterContainerMax
        {
            get { return waterContainerMax; }
            set { waterContainerMax = value; }
        }

        private string productContainerMax;

        public string ProductContainerMax
        {
            get { return productContainerMax; }
            set { productContainerMax = value; }
        }

        private string numberOfCupsMax;

        public string NumberOfCupsMax
        {
            get { return numberOfCupsMax; }
            set { numberOfCupsMax = value; }
        }


        public double GetMaxWaterLevel()
        {
            return waterContainerMax;
        }


        //public override string FillWaterContainerToMax()
        //{
        //    waterContainerMax = "1000 Milliliters";

        //    return WaterContainerMax;
        //}

        //public override string FillProductContainerToMax()
        //{
        //    productContainerMax = "500 Gram";
        //    return ProductContainerMax;
        //}

        //public override string NumberOfCupsToBeMade(double waterAmount)
        //{
        //    numberOfCupsMax = GetMaxWater() / waterAmount
        //}

        //public string GetMaxWater()
        //{
        //    return FillWaterContainerToMax().Substring(0,4);
        //}

        //public string GetMaxProduct()
        //{
        //    return FillProductContainerToMax().Substring(0, 3);
        //}


    }
}