using System;
namespace State
{
    public interface ATMState
    {
        void InsertCard();
        void EjectCard();
        void InsertPin(int pinEntered);
        void RequestCash(int cash);
    }
}