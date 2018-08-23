using System;
using System.Collections.Generic;

namespace StorageStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initalizing repos dictionary...");
            var repos = new Dictionary<Type, IRepository>();
            repos[typeof(Customer)] = new CustomerRepository();
            repos[typeof(Affiliate)] = new AffiliateRepository();
            
            var objects = new List<object> { new Customer(), new Affiliate() };
            Console.WriteLine($"Saving {objects.Count} items");
            foreach (var o in objects){
                repos[o.GetType()].Save(o);
            }
            Console.ReadLine();
        }
    }
}
