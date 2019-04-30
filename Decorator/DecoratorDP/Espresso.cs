namespace DecoratorDP
{
    public class Espresso : ICoffee //Concrete Component
    {
        public string GetDescription()
        {
            return "Espresso";
        }

        public double GetPrice()
        {
            return 1.5;
        }
    }
}
