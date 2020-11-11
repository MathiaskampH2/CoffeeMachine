namespace CoffeeMachine
{
    /// <summary>
    /// Tea Class
    /// Inherits form Drink
    /// </summary>
    public class Tea :Drink
    {
        public Tea(string name, double water, string product, double temperature) : base(name, water, product, temperature)
        {
        }
    }
}