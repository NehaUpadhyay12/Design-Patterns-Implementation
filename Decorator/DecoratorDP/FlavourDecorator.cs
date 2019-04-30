namespace DecoratorDP
{
    public abstract class FlavourDecorator : ICoffee //Decorator
    {
        ICoffee coffee;

        protected FlavourDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }
        public virtual string GetDescription()
        {
            return this.coffee.GetDescription();
        }

        public virtual double GetPrice()
        {
            return this.coffee.GetPrice();
        }
    }
}
