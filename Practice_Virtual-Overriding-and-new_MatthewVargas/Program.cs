namespace Practice_Virtual_Overriding_and_new_MatthewVargas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();

            // Create instances of each account type
            CheckingAccount checking = new CheckingAccount("Matthew Vargas", 1000, 20);
            SavingsAccount savings = new SavingsAccount("Jade Howard", 2000, 0.05);
            RetirementAccount retirement = new RetirementAccount("Lauren Mile", 5000, 0.08);

            // Add accounts to the list
            accounts.Add(checking);
            accounts.Add(savings);
            accounts.Add(retirement);

            // Deposit and withdraw from all accounts
            foreach (var account in accounts)
            {
                account.Deposit(500);
                account.Deposit(-50000);
                account.Withdraw(200);
                account.Withdraw(-200000);
                account.Withdraw(10000); // Overdraw
                Console.WriteLine(account.ToString() + "\n");
            }
        }
    }
}
