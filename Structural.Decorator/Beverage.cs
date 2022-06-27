namespace Structural.Decorator
{
    public abstract class Beverage
	{
        public string description { get; set; }
        public abstract string getDescription();
		public abstract double cost();
	}
}
