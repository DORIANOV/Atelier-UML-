public class TestJoueur
{
    public static void Main(string[] args)
    {

        Joueur joueur = new Joueur("Moi", 200);

        JoueurVue vue = new JoueurVue(joueur);

        JoueurControleur controleur = new JoueurControleur(joueur, vue);

        controleur.AfficherFicheJoueur();

        controleur.AjouterArgent(100);

        controleur.AfficherFicheJoueur();
    }
}
