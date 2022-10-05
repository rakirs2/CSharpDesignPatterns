namespace State.States;

public class HasCard : IAtmState
{
    private readonly AtmMachine _atmMachine;

    public HasCard(AtmMachine newAtmMachine)
    {
        _atmMachine = newAtmMachine;
    }

    public void InsertCard()
    {
        Console.WriteLine(
            "The ATM only has room for one card... I am a single threaded ATM machine and here you are attempted to add concurrency");
    }

    public void EjectCard()
    {
        Console.WriteLine("The card is ejected. Improve your credit score so you don't feed me such unworthy cards");
        _atmMachine.SetATMState(_atmMachine.GetNoCardState());
    }

    public void InsertPin(int pinEntered)
    {
        if (pinEntered == 1234 || pinEntered == 13190620)
        {
            Console.WriteLine("Welcome To Microsoft and C#, your pin is correct");
            _atmMachine.CorrectPinEntered = true;
            _atmMachine.SetATMState(_atmMachine.GetHasPin());
        }
        else
        {
            Console.WriteLine("Wrong Pin, company ticker by numbers in alphabet or the default pin");
            _atmMachine.CorrectPinEntered = true;
            Console.WriteLine("Rejected");
            _atmMachine.SetATMState(_atmMachine.GetNoCardState());
        }
    }

    public void RequestCash(int cash)
    {
        Console.Write("You need to put your pin first");
    }
}