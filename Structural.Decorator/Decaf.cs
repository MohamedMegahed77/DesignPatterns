

namespace Structural.Decorator
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }
        public override double cost()
        {
            return 1.05;
        }
        public override string getDescription()
        {
            return description;
        }
    }
}
