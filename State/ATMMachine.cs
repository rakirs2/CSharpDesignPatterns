using System;
namespace State
{
    public class ATMMachine
    {
        ATMState _hasCard;
        ATMState _noCard;
        ATMState _hasCorrectPin;
        ATMState _atmOutOfMoney;

        private ATMState _atmState;
        private int _cashInMachine = 2000;
        private boolean _correctPinEntered = false;

        public ATMMachine()
        {
            _hasCard = new HasCard(this);
            _noCard = new NoCard(this);
            _hasCorrectPin = new HasPin();
            _atmOutOfMoney = new NoCash();

            atmState = _noCard;
            if (_cashInMachine < 0)
            {
                atmState = _atmOutOfMoney;
                
            }
            
            

        }

        void SetATMState(ATMState newATMState)
        {
            atmState = newATMState;
            
        }

        public void SetCashInMachine(int newCashInMachine)
        {
            _cashInMachine = newCashInMachine;
        }

        public void InsertCard()
        {
            atmState.insertCard();
        }

        public void EjectCard()
        {
            _atmState.ejectCard();
        }
        
        
    }
}

