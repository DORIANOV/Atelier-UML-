using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp3
{
    public class Case
    {
        public int Numero { get; private set; }
        public string Nom { get; private set; }

        public Case(int numero, string nom)
        {
            Numero = numero;
            Nom = nom;
        }

        public void Afficher()
        {
            Console.WriteLine($"Case {Numero}: {Nom}");
        }
    }

}
