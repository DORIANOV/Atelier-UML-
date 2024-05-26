public class JoueurControleur
{
    private Joueur _model;
    private JoueurVue _vue;

    public JoueurControleur(Joueur model, JoueurVue vue)
    {
        _model = model;
        _vue = vue;
    }

    public void AfficherFicheJoueur()
    {
        _vue.AfficherFicheJoueur();
    }

    public void AjouterArgent(int montant)
    {
        _model.Cash += montant;
        _vue.AfficherFicheJoueur();
    }
}
