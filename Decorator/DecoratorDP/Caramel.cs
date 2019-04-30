namespace DecoratorDP
{
    public class Caramel : FlavourDecorator //Concrete Decorator
    {

        public Caramel(ICoffee coffee) : base(coffee)
        {
        }
        public override string GetDescription()
        {
            return "Caramel " + base.GetDescription();
        }

        public override double GetPrice()
        {
            return base.GetPrice() + .50;
        }
    }
}
