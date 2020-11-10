﻿namespace CoffeeMachine
{

    /// <summary>
    /// CoffeeMachine class
    /// Is inheriting from HotDrinkMaker which is its superClass
    /// You are able to make objects of this class.
    /// </summary>
    public class CoffeeMachine :HotDrinkMaker
    {
        public CoffeeMachine(string waterContainer, string productContainer) : base(waterContainer, productContainer)
        {
        }
    }
}