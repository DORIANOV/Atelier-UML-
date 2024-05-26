using System;

public class Banque
{
    private static Banque instance;
    private static readonly object padlock = new object();
    private int cash;
    private Banque()
    {
    }  public static Banque Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Banque();
                }
                return instance;
            }
        }
    }public int GetCash()
    {
        return cash;
    }
public void SetCash(int value)
    {
        cash = value;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Banque b1 = Banque.Instance;
        b1.SetCash(1000);
        Console.WriteLine("Cash de b1: " + b1.GetCash());
        Banque b2 = Banque.Instance;
        b2.SetCash(500);
        Console.WriteLine("Cash de b2: " + b2.GetCash());

        Console.WriteLine("Cash de b1 après b2: " + b1.GetCash());
    }
}
