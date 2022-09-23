using BankEncapsulation;

//New account
var firstCustomer = new BankAccount();

//Deposit funds
firstCustomer.Deposit(40000);

//Console.WriteLine($"New balance: " + firstCustomer.GetBalance());
//Withdraw funds
firstCustomer.Withdraw(3200);

Console.WriteLine($"New balance: " + firstCustomer.GetBalance());


//Trying to directly print balance will result in an error due to access level
//Console.WriteLine(firstCustomer._balance);
