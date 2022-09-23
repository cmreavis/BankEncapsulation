using BankEncapsulation;

//New account
BankAccount firstCustomer = new BankAccount(0);

//Deposit funds
firstCustomer.Deposit(40000);

Console.WriteLine(firstCustomer.GetBalance());
//Withdraw funds
firstCustomer.Withdraw(3200);

Console.WriteLine(firstCustomer.GetBalance());


//Trying to directly print balance will result in an error due to access level
//Console.WriteLine(firstCustomer.balance);
