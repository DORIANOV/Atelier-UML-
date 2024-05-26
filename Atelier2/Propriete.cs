using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp2
{
    internal abstract class Propriete
    {
        public string Nom { get; set; }
        public int Prix { get; set; }
        public Propriete(string nom, int prix)
        {
            Nom = nom;
            Prix = prix;
        }
        
        public virtual void Afficher()
        {
            Console.WriteLine();
            Console.Write("{0} - {1} euros", Nom, Prix);
        }

        public abstract int CalculerLoyer();
    }
}
