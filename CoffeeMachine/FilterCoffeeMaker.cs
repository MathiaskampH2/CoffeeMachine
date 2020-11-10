namespace CoffeeMachine
{
    public class FilterCoffeeMaker:Drink
    {
        public FilterCoffeeMaker(double water, string product, double temperature) : base(water, product, temperature)
        {
            water = 200;
            temperature = 93;
        }
    }
}