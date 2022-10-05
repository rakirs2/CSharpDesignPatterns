using State.States;

namespace State;

public class AtmMachine
{
    private readonly IAtmState _atmOutOfMoney;
    private readonly IAtmState _hasCard;
    private readonly IAtmState _hasCorrectPin;
    private readonly IAtmState _noCard;

    private IAtmState _atmState;
    internal int CashInMachine = 2000;
    internal bool CorrectPinEntered = false;

    public AtmMachine()
    {
        _hasCard = new HasCard(this);
        _noCard = new NoCard(this);
        _hasCorrectPin = new HasPin(this);
        _atmOutOfMoney = new NoCash(this);

        //fundamentally, this is the thing that's going to be changing
        _atmState = _noCard;
        if (CashInMachine < 0) _atmState = _atmOutOfMoney;
    }

    internal void SetATMState(IAtmState newATMState)
    {
        _atmState = newATMState;
    }

    public void SetCashInMachine(int newCashInMachine)
    {
        CashInMachine = newCashInMachine;
    }

    public void InsertCard()
    {
        _atmState.InsertCard();
    }

    public void EjectCard()
    {
        _atmState.EjectCard();
    }

    public void InsertPin(int pinEntered)
    {
        _atmState.InsertPin(pinEntered);
    }

    public IAtmState GetYesCardState()
    {
        return _hasCard;
    }

    public IAtmState GetNoCardState()
    {
        return _noCard;
    }

    public IAtmState GetHasPin()
    {
        return _hasCorrectPin;
    }

    public IAtmState GetNoCashState()
    {
        return _atmOutOfMoney;
    }


    public void RequestCash(int i)
    {
        _atmState.RequestCash(i);
    }
}