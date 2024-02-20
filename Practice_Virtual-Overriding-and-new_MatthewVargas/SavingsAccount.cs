using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Virtual_Overriding_and_new_MatthewVargas
{
    internal class SavingsAccount : BankAccount
    {
        public double Interest { get; set; }

        public SavingsAccount(string name, double balance, double interest) : base(name, balance)
        {
            Interest = interest;
        }

        public override bool Deposit(double amount)
        {
            if (base.Deposit(amount))
            {
                // Add interest to the account
                Balance = Balance + (Balance * Interest);
                Console.WriteLine($"With interest, new balance: ${Balance}");
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Interest: {Interest * 100}%"; //Interest, fun stuff
        }
    }
}