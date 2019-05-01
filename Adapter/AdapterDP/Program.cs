using System;
using System.Collections.Generic;

namespace AdapterDP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IShoppingSiteTarget shopping = new Adapter();
            foreach (var item in shopping.GetProducts())
            {
                Console.WriteLine(item);
            }
        }
    }

    public interface IShoppingSiteTarget
    {
        List<string> GetProducts();
    }

    public class VendorAdaptee
    {
        public List<string> Products => new List<string> { "Television", "Books", "Cosmetics"};
    }

    public class Adapter : IShoppingSiteTarget
    {
        public List<string> GetProducts()
        {
            VendorAdaptee adaptee = new VendorAdaptee();
            return adaptee.Products;
        }
    }
}
