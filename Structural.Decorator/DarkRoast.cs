namespace Structural.Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }

        public override double cost()
        {
            return .99;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}
