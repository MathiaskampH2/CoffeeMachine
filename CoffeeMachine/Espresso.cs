namespace CoffeeMachine
{
    /// <summary>
    /// Espresso Class
    /// Inherits from Drink
    /// </summary>
    public class Espresso:Drink
    {
        public Espresso(string name, double water, string product, double temperature) : base(name, water, product, temperature)
        {
        }
    }
}