namespace DecoratorDP
{
    public class Hazelnut : FlavourDecorator //Concrete Decorator
    {
        public Hazelnut(ICoffee coffee) : base(coffee)
        {
        }
        public override string GetDescription()
        {
            return "Hazelnut " + base.GetDescription();
        }

        public override double GetPrice()
        {
            return base.GetPrice() + .20;
        }
    }
}
