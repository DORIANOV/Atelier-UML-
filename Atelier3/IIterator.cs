using BanqueApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp3
{   public interface IIterator
    {
        bool MoveNext();
        void Reset();
        Case Current { get; }
    }
}
