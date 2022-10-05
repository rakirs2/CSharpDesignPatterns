namespace State.States;

public class NoCash : IAtmState
{
    private AtmMachine _atmMachine;

    public NoCash(AtmMachine atmMachine)
    {
        _atmMachine = atmMachine;
    }

    public void InsertCard()
    {
        Console.WriteLine("We Got No $$");
        Console.WriteLine("Card Ejected");
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