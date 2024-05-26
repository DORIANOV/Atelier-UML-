using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp2
{
    internal class FabriqueTerrain : FabriquePropriete
    {
        private static FabriqueTerrain instance;

        private FabriqueTerrain() { }

        public static FabriqueTerrain GetInstance()
        {
            if (instance == null)
            {
                instance = new FabriqueTerrain();
            }
            return instance;
        }

        public override Propriete Creer(string nom, int prix)
        {
            return new Terrain(nom, prix);
        }
    }
}
