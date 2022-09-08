namespace State;

public class HasCard:ATMState
{
    private ATMMachine _atmMachine;

    public HasCard(ATMMachine newATMMachine)
    {
        _atmMachine = newATMMachine;
    }
    public void InsertCard()
    {
        Console.WriteLine("The ATM only has room for one card... I am a single threaded ATM machine and here you are attempted to add concurrency");
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
        }
    }

    public void RequestCash(int cash)
    {
        throw new NotImplementedException();
    }
}