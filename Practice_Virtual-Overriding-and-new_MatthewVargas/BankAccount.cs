using System;

internal class BankAccount
{
    private static readonly Random random = new Random();
    private int _accountNumber;
    //^To create a random account number
    public string Name { get; set; }
    public int AccountNumber { get { return _accountNumber; } }
    public double Balance { get; protected set; }

    public BankAccount(string name, double balance)
    {
        Name = name;
        Balance = balance;
        _accountNumber = GenerateRandomNumber(); //Calling generator to do it's job
    }

    private static int GenerateRandomNumber()
    {
        return random.Next(9999) - 1000; //Random 4 digit account number, to look like something normal
    }
    //^Random number generator
    public virtual bool Deposit(double amount)
    {
        if (amount > 0) //Validating for if it's a valid amount
        {
            Balance = Balance + amount;
            Console.WriteLine($"{Name} - Account #{_accountNumber}\n" +
                              $"Your balance is ${Balance}"); //Example: Matthew - Account #: 4584 | Balance is $400005
            return true; //Transaction completed is sent :)
        }
        else //If validation fails then amount becomes invalid, returns as failed
        {
            Console.WriteLine($"Deposit of ${amount} invalid"); //Example: Deposit of $-22222 invalid
            return false; //Transaction failed is sent :(
        }
    }

    public virtual bool Withdraw(double amount)
    {
        if (amount > 0 && Balance >= amount)
        {
            Balance = Balance - amount;
            Console.WriteLine($"{Name} - Account #: {_accountNumber}\n" +
                              $"Your balance is: ${Balance}");
            return true; //Copied deposit pretty much
        }
        else
        {
            Console.WriteLine($"Withdrawl amount ${amount} invalid or not enough money");
            return false;
        }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} - {Name} - Account #{_accountNumber} - Balance: ${Balance}";
    }
}
