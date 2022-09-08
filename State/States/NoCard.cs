namespace State;

public class NoCard:ATMState
{
    private ATMMachine _atmMachine;
    public void InsertCard()
    {
        Console.WriteLine("Enter Pin");
        _atmMachine.SetATMState(_atmMachine.GetYesCardState());
    }

    public void EjectCard()
    {
        throw new NotImplementedException();
    }

    public void InsertPin(int pinEntered)
    {
        throw new NotImplementedException();
    }

    public void RequestCash(int cash)
    {
        throw new NotImplementedException();
    }
}