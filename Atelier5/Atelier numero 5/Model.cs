﻿public class Joueur
{
    public string Prenom { get; set; }
    public int Cash { get; set; }

    public Joueur(string prenom, int cash)
    {
        Prenom = prenom;
        Cash = cash;
    }
}
