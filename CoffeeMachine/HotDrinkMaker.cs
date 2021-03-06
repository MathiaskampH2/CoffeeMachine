﻿using System;

namespace CoffeeMachine
{
    /// <summary>
    /// HotDrinkMaker class
    /// This class is responsible of beeing a "Hot drink Machine"
    /// In this case i use it to make a CoffeMachine object.
    /// 
    /// </summary>
    public abstract class HotDrinkMaker
    {
        protected double waterContainer;

        public double WaterContainer
        {
            get => waterContainer;
            set => waterContainer = value;
        }


        protected HotDrinkMaker(double waterContainer)
        {
            this.waterContainer = waterContainer;
        }

        public override string ToString()
        {
            return
                "Water container level :" + waterContainer + "\n";

        }
    }
}