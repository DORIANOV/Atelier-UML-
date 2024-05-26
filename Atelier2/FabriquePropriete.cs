using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp2
{
    internal abstract class FabriquePropriete
    {
        public abstract Propriete Creer(string nom, int prix);
    }
}
