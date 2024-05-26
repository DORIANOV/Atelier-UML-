public class Property
{
    public string Name;
    public string Owner;
    public bool IsMortgaged;
    public int Houses;
    public int BaseRent;
    public int[] RentWithHouses;

    public Property(string name, int baseRent, int[] rentWithHouses)
    {
        Name = name;
        BaseRent = baseRent;
        RentWithHouses = rentWithHouses;
    }
}

public class Game
{
    static void Main(string[] args)
    {
        Handler bankOwned = new BankOwnedHandler();
        Handler playerOwned = new PlayerOwnedHandler();
        Handler mortgaged = new MortgagedHandler();
        Handler built = new BuiltHandler();

        bankOwned.SetSuccessor(playerOwned);
        playerOwned.SetSuccessor(mortgaged);
        mortgaged.SetSuccessor(built);

        Property rueDeLaPaix = new Property("Rue de la Paix", 50, new int[] { 10, 30, 90, 160, 250 });

        rueDeLaPaix.Owner = "banque";
        Console.WriteLine("Rent when owned by bank: " + bankOwned.HandleRequest(rueDeLaPaix));

        rueDeLaPaix.Owner = "Joueur";
        Console.WriteLine("Rent when owned by player: " + bankOwned.HandleRequest(rueDeLaPaix));

        rueDeLaPaix.IsMortgaged = true;
        Console.WriteLine("Rent when mortgaged: " + bankOwned.HandleRequest(rueDeLaPaix));

        rueDeLaPaix.IsMortgaged = false;
        rueDeLaPaix.Houses = 1;
        Console.WriteLine("Rent with 1 house: " + bankOwned.HandleRequest(rueDeLaPaix));
    }
}
