namespace State;

public class NoCash:ATMState
{
    private ATMMachine _atmMachine;
    public NoCash(ATMMachine atmMachine)
    {
        _atmMachine = atmMachine;
    }
    public void InsertCard()
    {
        Console.WriteLine("We Got No $$");
        Console.WriteLine("Card EJected");
    }

    public void EjectCard()
    {
        Console.WriteLine("We Got No $$");
        Console.WriteLine("This should never be reached");

    }

    public void InsertPin(int pinEntered)
    {
        Console.WriteLine("We Got No $$");
    }

    public void RequestCash(int cash)
    {
        Console.WriteLine("We Got No $$");
    }
}