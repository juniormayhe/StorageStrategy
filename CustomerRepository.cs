using System;
using System.Collections.Generic;
using System.Text;

namespace StorageStrategy
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Save(object o)
        {
            Console.WriteLine($"{nameof(o)}: {o.GetType()} saved");
        }
    }
}
