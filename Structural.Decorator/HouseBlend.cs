namespace Structural.Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }
        public override double cost()
        {
            return .89;
        }
        public override string getDescription()
        {
            return description;
        }
    }
}
