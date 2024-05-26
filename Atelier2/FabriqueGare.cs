using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp2
{
    internal class FabriqueGare : FabriquePropriete
    {
        public override Propriete Creer(string nom, int prix)
        {
            return new Gare(nom, prix);
        }
    }
}
