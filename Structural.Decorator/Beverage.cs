namespace Structural.Decorator
{
    public abstract class Beverage
	{
		string description = "Unknown Beverage";

		public string getDescription()
		{
			return description;
		}

		public abstract double cost();
	}
}
