using System;

namespace CoffeeMachine
{

    /// <summary>
    /// FilterCoffee Class
    /// Is inhering from Drink class
    /// makes me able to make an object of FilterCoffee
    /// </summary>
    public class FilterCoffee : Drink
    {

        public FilterCoffee(string name, double water, string product, double temperature) : base(name, water, product, temperature)
        {
            water = 200;
            temperature = 93;
        }
        
    }
}