using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee: HotBeverage
    {


        private const double coffeeMilliliters = 50;
        private const decimal coffeePrice = 3.50M;

        public Coffee(string name, double caffeine)
            : base(name, 0, 0)
        {
            this.Caffeine = caffeine;
        }

        public override double Milliliters { get => coffeeMilliliters; }

        public override decimal Price { get => coffeePrice; }

        public double Caffeine { get; set; }
        //public Coffee(string name, decimal price, double milli,double caffeine) : base(name, 3.5m  , 50)
        //{
        //    Caffeine = caffeine;
        //}


        //public double Caffeine  { get; set; }


    }
}
