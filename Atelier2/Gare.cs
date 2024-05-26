using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp2
{
    internal class Gare : Propriete
    {
        public Gare(string nom, int prix) : base(nom, prix) { }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine(" et je suis une gare");
        }

        public override int CalculerLoyer()
        {
            Console.WriteLine("Je calcule le loyer d'une gare");
            return Prix;
        }
    }
}
