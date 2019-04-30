using System;

namespace DecoratorDP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ICoffee caramelHazelnutEspresso = new Caramel(new Hazelnut(new Espresso())); //Cost of Caramel Hazelnut Espresso
            Console.WriteLine($"You bought {caramelHazelnutEspresso.GetDescription()} worth ${caramelHazelnutEspresso.GetPrice()}");
        }
    }
}
