using System;

namespace BanqueApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plateau plateau = new Plateau();

            for (int i = 1; i <= 10; i++)
            {
                plateau.AjouterCase(new Case(i, $"Case {i}"));
            }

            IIterator iterator = plateau.CreateIterator();

            while (iterator.MoveNext())
            {
                Case currentCase = iterator.Current;
                currentCase.Afficher();
            }
        }
    }
}
