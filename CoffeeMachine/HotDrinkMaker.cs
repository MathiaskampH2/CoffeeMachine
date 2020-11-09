namespace CoffeeMachine
{
    public abstract class HotDrinkMaker
    {
        protected double waterContainer;

        public double WaterContainer
        {
            get { return waterContainer; }
            set { waterContainer = value; }
        }

        protected double productContainer;

        public double ProductContainer
        {
            get { return productContainer; }
            set { productContainer = value; }
        }

        protected int numberOfCups;

        public int NumberOfCups
        {
            get { return numberOfCups; }
            set { numberOfCups = value; }
        }

        protected bool startButton;

        public bool StartButton
        {
            get { return startButton; }
            set { startButton = value; }
        }

        public abstract double FillWaterContainer();

        public abstract double FillProductContainer();

        public abstract string GetNumberOfCups();


        protected HotDrinkMaker(double waterContainer, double productContainer, int numberOfCups)
        {
            this.numberOfCups = numberOfCups;
            this.productContainer = productContainer;
            this.waterContainer = waterContainer;
        }

    }
}