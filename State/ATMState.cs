namespace State;

public interface IAtmState
{
    void InsertCard();
    void EjectCard();
    void InsertPin(int pinEntered);
    void RequestCash(int cash);
}