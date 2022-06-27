using System;

namespace Structural.Decorator
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

       public override double cost()
        {
            return 1.99;
        }
        public override string getDescription()
        {
            return description;
        }
    }
}
