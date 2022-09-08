using State;

var atmMachine = new ATMMachine();

atmMachine.InsertCard();

atmMachine.EjectCard();

atmMachine.InsertCard();

atmMachine.InsertPin(1234);

atmMachine.RequestCash(2000);

atmMachine.InsertCard();

atmMachine.InsertPin(1234);