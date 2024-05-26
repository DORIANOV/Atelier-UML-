public class JoueurVue
{
    private Joueur _joueur;

    public JoueurVue(Joueur joueur)
    {
        _joueur = joueur;
    }

    public void AfficherFicheJoueur()
    {
        Console.WriteLine($"Prénom : {_joueur.Prenom}");
        Console.WriteLine($"Cash : {_joueur.Cash}");
    }
}
