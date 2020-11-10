using System;

namespace CoffeeMachine
{
    /// <summary>
    /// Drink Class
    /// This class responsible is making me able to make Drink objects
    /// It has an override of ToString method.
    /// </summary>
    public abstract class Drink
    {
        protected double waterAmount;

        public double WaterAmount
        {
            get { return waterAmount; }
            set { waterAmount = value; }
        }

        protected string product;

        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        protected double temperature;

        public double Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        protected Drink(double water,  string product, double temperature)
        {
            this.product = product;
            this.waterAmount = water;
            this.temperature = temperature;
        }

        public override string ToString()
        {
            return
                "Water amount :" + waterAmount + " Ml" + "\n"
                + "Product type :" + product  + "\n"
                + "temperature of product : " + temperature + " Degrees" + "\n";
        }
    }
}