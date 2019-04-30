namespace DecoratorDP
{
    public class Cappucino : ICoffee //Concrete Component
    {
        public string GetDescription()
        {
            return "Cappucino";
        }

        public double GetPrice()
        {
            return 2.99;
        }
    }
}
