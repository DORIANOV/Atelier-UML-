using BanqueApp2;
using System;

namespace BanqueApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            FabriquePropriete fab;

            fab = FabriqueTerrain.GetInstance();
            Propriete p1 = fab.Creer("Rue de la paix", 400);
            p1.Afficher();
            Propriete p2 = fab.Creer("Rue de Courcelles", 50);
            p2.Afficher();

            fab = new FabriqueGare();
            Propriete p3 = fab.Creer("MontParnasse", 200);
            p3.Afficher();

        }
    }
}
