using System;

namespace CoffeeMachine
{
    public abstract class Drink
    {
        protected double waterAmount;

        public double WaterAmount
        {
            get { return waterAmount; }
            set { waterAmount = value; }
        }

        protected double productAmount;

        public double ProductAmount
        {
            get { return productAmount; }
            set { productAmount = value; }
        }

        protected double temperature;

        public double Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        protected Drink(double water,  double product, double temperature)
        {
            this.productAmount = product;
            this.waterAmount = water;
            this.temperature = temperature;
        }

        public override string ToString()
        {
            return
                "Water amount :" + waterAmount +" Ml"+ "\n"
                + "Product amount :" + productAmount + " Gram" + "\n"
                + "temperature of product : " + temperature + " Degrees"+ "\n";
        }
    }
}