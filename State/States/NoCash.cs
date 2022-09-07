namespace State;

public class NoCash:ATMState
{
    public void insertCard()
    {
        throw new NotImplementedException();
    }

    public void ejectCard()
    {
        throw new NotImplementedException();
    }

    public void insertPin(int pinEntered)
    {
        throw new NotImplementedException();
    }

    public void requestCash(int cash)
    {
        throw new NotImplementedException();
    }
}