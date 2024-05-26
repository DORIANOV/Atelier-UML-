using System.Collections.Generic;
using System.Linq;

public class JoueurDaoImpl : JoueurDao
{
    private List<Joueur> joueurs;

    public JoueurDaoImpl()
    {
        joueurs = new List<Joueur>
        {
            new Joueur("Damien", 500),
            new Joueur("Matéo", 300),
            new Joueur("Dorian", 400)
        };
    }
    public List<Joueur> GetTousLesJoueurs()
    {
        return joueurs;
    }

    public void UpdateJoueur(Joueur joueur)
    {
        var existingJoueur = joueurs.FirstOrDefault(j => j.Prenom == joueur.Prenom);
        if (existingJoueur != null)
        {
            existingJoueur.Cash = joueur.Cash;
        }
    }

    public void DeleteJoueur(Joueur joueur)
    {
        joueurs.RemoveAll(j => j.Prenom == joueur.Prenom);
    }

    public void AddJoueur(Joueur joueur)
    {
        joueurs.Add(joueur);
    }
}
