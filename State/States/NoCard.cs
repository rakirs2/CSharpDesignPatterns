namespace State.States;

public class NoCard : IAtmState
{
    private readonly AtmMachine _atmMachine;

    public NoCard(AtmMachine atmMachine)
    {
        _atmMachine = atmMachine;
    }

    public void InsertCard()
    {
        Console.WriteLine("Enter Pin");
        _atmMachine.SetATMState(_atmMachine.GetYesCardState());
    }

    public void EjectCard()
    {
        Console.WriteLine("Card not available. Existence Abnormality");
    }

    public void InsertPin(int pinEntered)
    {
        Console.WriteLine("You need a card");
    }

    public void RequestCash(int cash)
    {
        Console.WriteLine("What is this, a PPP loan?");
    }
}