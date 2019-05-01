using System;

namespace AbstractFactoryDP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PhoneTypeChecker typeChecker = new PhoneTypeChecker();
            typeChecker.CheckPhone("Nokia");
            typeChecker.CheckPhone("Htc");
            typeChecker.CheckPhone("Samsung");
        }
    }

    public class PhoneTypeChecker
    {
        IPhoneFactory factory;
        public void CheckPhone(string brand)
        {
            switch (brand)
            {
                case "Nokia":
                    factory = new NokiaFactory();
                    break;
                case "Htc":
                    factory = new HTCFactory();
                    break;
                case "Samsung":
                    factory = new SamsungFactory();
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Basic Phone available is {factory.GetBasic().GetName()}. Smart phone available is {factory.GetSmart().GetName()}");
        }
    }
    public interface ISmart //Abstract Product
    {
        string GetName();
    }

    public interface IBasic //Abstract product
    {
        string GetName();
    }

    public class Asha : IBasic
    {
        public string GetName()
        {
            return "Asha";
        }
    }

    public class Primo : IBasic
    {
        public string GetName()
        {
            return "Primo";
        }
    }

    public class Genie : IBasic
    {
        public string GetName()
        {
            return "Genie";
        }
    }

    public class Lumia : ISmart
    {
        public string GetName()
        {
            return "Lumia";
        }
    }

    public class GalaxyS2 : ISmart
    {
        public string GetName()
        {
            return "GalaxyS2";
        }
    }

    public class Titan : ISmart
    {
        public string GetName()
        {
            return "Titan";
        }
    }

    public interface IPhoneFactory //Abstract Factory
    {
        ISmart GetSmart();
        IBasic GetBasic();
    }

    public class SamsungFactory : IPhoneFactory
    {
        public IBasic GetBasic()
        {
            return new Primo();
        }

        public ISmart GetSmart()
        {
            return new GalaxyS2();
        }
    }

    public class HTCFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new Titan();
        }

        public IBasic GetBasic()
        {
            return new Genie();
        }
    }

    public class NokiaFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new Lumia();
        }

        public IBasic GetBasic()
        {
            return new Asha();
        }
    }
}
