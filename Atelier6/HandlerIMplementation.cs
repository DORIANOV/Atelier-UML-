public class BankOwnedHandler : Handler
{
    public override int HandleRequest(Property property)
    {
        if (property.Owner == "banque")
            return 0;
        else if (successor != null)
            return successor.HandleRequest(property);
        return 0;
    }
}

public class PlayerOwnedHandler : Handler
{
    public override int HandleRequest(Property property)
    {
        if (property.Owner == "joueur" && !property.IsMortgaged && property.Houses == 0)
            return property.BaseRent;
        else if (successor != null)
            return successor.HandleRequest(property);
        return 0;
    }
}

public class MortgagedHandler : Handler
{
    public override int HandleRequest(Property property)
    {
        if (property.IsMortgaged)
            return 0;
        else if (successor != null)
            return successor.HandleRequest(property);
        return 0;
    }
}

public class BuiltHandler : Handler
{
    public override int HandleRequest(Property property)
    {
        if (property.Houses > 0)
            return property.RentWithHouses[property.Houses - 1];
        else if (successor != null)
            return successor.HandleRequest(property);
        return 0;
    }
}
