using System;
//TODO.Srikar get this to work?
namespace State
{
    public class ATMMachine
    {
        ATMState _hasCard;
        ATMState _noCard;
        ATMState _hasCorrectPin;
        ATMState _atmOutOfMoney;

        private ATMState _atmState;
        internal int _cashInMachine = 2000;
        internal Boolean _correctPinEntered = false;

        public ATMMachine()
        {
            _hasCard = new HasCard(this);
            _noCard = new NoCard(this);
            _hasCorrectPin = new HasPin(this);
            _atmOutOfMoney = new NoCash(this);

            //fundamentally, this is the thing that's going to be changing
            _atmState = _noCard;
            if (_cashInMachine < 0)
            {
                _atmState = _atmOutOfMoney;
            }
            
            

        }

        internal void SetATMState(ATMState newATMState)
        {
            _atmState = newATMState;
        }

        public void SetCashInMachine(int newCashInMachine)
        {
            _cashInMachine = newCashInMachine;
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

        public ATMState GetYesCardState()
        {
            return _hasCard;
        }
        public ATMState GetNoCardState()
        {
            return _noCard;
        }

        public ATMState GetHasPin()
        {
            return _hasCorrectPin;
        }

        public ATMState GetNoCashState()
        {
            return _atmOutOfMoney;
        }
        
        
    }
}

