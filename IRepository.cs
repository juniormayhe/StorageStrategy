using System;
using System.Collections.Generic;
using System.Text;

namespace StorageStrategy
{
    public interface IRepository
    {
        void Save(object o);
    }
}
