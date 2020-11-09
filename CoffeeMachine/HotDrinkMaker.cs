namespace CoffeeMachine
{
    public abstract class HotDrinkMaker
    {
        protected double waterContainer;

        public double WaterContainer
        {
            get => waterContainer;
            set => waterContainer = value;
        }

        protected double productContainer;

        public double ProductContainer
        {
            get => productContainer;
            set => productContainer = value;
        }

        //protected int numberOfCups;

        //public int NumberOfCups
        //{
        //    get => numberOfCups;
        //    set => numberOfCups = value;
        //}

     

        //public abstract string FillWaterContainerToMax();

        //public abstract string FillProductContainerToMax();

        //public abstract string NumberOfCupsToBeMade(double waterAmount);


        protected HotDrinkMaker(double waterContainer, double productContainer)
        {
            //this.numberOfCups = numberOfCups;
            this.productContainer = productContainer;
            this.waterContainer = waterContainer;
        }

    }
}