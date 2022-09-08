using State;

var atmMachine = new ATMMachine();

atmMachine.InsertCard();

atmMachine.ejectCard();

atmMachine.insertCard();

atmMachine.insertPin(1234);

atmMachine.requestCash(2000);

atmMachine.insertCard();

atmMachine.insertPin(1234);