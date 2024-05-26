using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp3
{
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}
