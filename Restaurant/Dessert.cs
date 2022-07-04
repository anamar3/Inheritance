using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Dessert: Food
    {
        public Dessert(string name, decimal price, double grams,double calls) : base(name, price, grams)
        {
            Calories = calls;
        }
        public virtual double Calories { get; set; }
    }
}
