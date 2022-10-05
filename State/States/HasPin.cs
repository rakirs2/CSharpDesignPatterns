namespace State.States;

public class HasPin : IAtmState
{
    private readonly AtmMachine _atmMachine;

    public HasPin(AtmMachine atmMachine)
    {
        _atmMachine = atmMachine;
    }

    public void InsertCard()
    {
        Console.WriteLine("this is not a 2 for one special");
    }

    public void EjectCard()
    {
        Console.WriteLine("card ejected");
        _atmMachine.SetATMState(_atmMachine.GetNoCardState());
    }

    public void InsertPin(int pinEntered)
    {
        Console.Write("Someone Likes Security");
    }

    public void RequestCash(int cashToWithdraw)
    {
        if (cashToWithdraw > _atmMachine.CashInMachine)
        {
            Console.WriteLine("You don't have that much cash available");

            Console.WriteLine("Your card is ejected");

            _atmMachine.SetATMState(_atmMachine.GetNoCardState());
        }
        else
        {
            Console.WriteLine(cashToWithdraw + " is provided by the machine");

            _atmMachine.SetCashInMachine(_atmMachine.CashInMachine - cashToWithdraw);

            Console.WriteLine("Your card is ejected");

            _atmMachine.SetATMState(_atmMachine.GetNoCardState());

            if (_atmMachine.CashInMachine <= 0) _atmMachine.SetATMState(_atmMachine.GetNoCashState());
        }
    }
}