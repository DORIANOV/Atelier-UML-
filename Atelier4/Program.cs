using System;

public class TestJoueurDao
{
    public static void Main(string[] args)
    {
        JoueurDao joueurDao = new JoueurDaoImpl();
        Console.WriteLine("Liste de joueurs  :");
        foreach (Joueur joueur in joueurDao.GetTousLesJoueurs())
        {
            Console.WriteLine(joueur);
        }
        foreach (Joueur joueur in joueurDao.GetTousLesJoueurs())
        {
            joueur.Cash += 100;
        }
        foreach (Joueur joueur in joueurDao.GetTousLesJoueurs())
        {
            joueurDao.UpdateJoueur(joueur);
        }
        Joueur joueurASupprimer = new Joueur("Bob", 0);
        joueurDao.DeleteJoueur(joueurASupprimer);
        Console.WriteLine("\nListe des joueurs après modifications :");
        foreach (Joueur joueur in joueurDao.GetTousLesJoueurs())
        {
            Console.WriteLine(joueur);
        }
    }
}
