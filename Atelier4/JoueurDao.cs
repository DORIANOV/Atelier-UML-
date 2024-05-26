using System.Collections.Generic;

public interface JoueurDao
{
    List<Joueur> GetTousLesJoueurs();
    void UpdateJoueur(Joueur joueur);
    void DeleteJoueur(Joueur joueur);
    void AddJoueur(Joueur joueur);
}
