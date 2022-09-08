namespace State;

public class NoCash:ATMState
{
    public void InsertCard()
    {
        throw new NotImplementedException();
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