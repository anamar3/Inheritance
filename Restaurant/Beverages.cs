using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage: Product
    {
        public Beverage(string name,decimal price,double milli):base(name,price)
        {
            Milliliters = milli;
        }
        public virtual double Milliliters  { get; set; }
    }
}
