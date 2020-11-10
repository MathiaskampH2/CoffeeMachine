namespace CoffeeMachine
{
    public class BrewingUnit
    {
        public Drink MakeDrink(int userChoseDrink)
        {
            switch (userChoseDrink)
            {
                case 1:
                    return new FilterCoffeeMaker(200, 100, 93);

                default:
                    return null;

            }

        }
    }
}