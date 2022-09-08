namespace State;

public class NoCard:ATMState
{
    private ATMMachine _atmMachine;

    public NoCard(ATMMachine atmMachine)
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