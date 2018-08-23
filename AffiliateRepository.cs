using System;
using System.Collections.Generic;
using System.Text;

namespace StorageStrategy
{
    public class AffiliateRepository : IAffiliateRepository
    {
        public void Save(object o)
        {
            Console.WriteLine($"{nameof(o)}: {o.GetType()} saved");
        }
    }
}
