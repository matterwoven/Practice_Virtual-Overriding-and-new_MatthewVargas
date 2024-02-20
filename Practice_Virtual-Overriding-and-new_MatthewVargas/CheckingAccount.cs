using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Virtual_Overriding_and_new_MatthewVargas
{
    internal class CheckingAccount : BankAccount
    {
        public double OverdraftFee { get; set; }

        public CheckingAccount(string name, double balance, double overdraftFee) : base(name, balance)
        {
            OverdraftFee = overdraftFee;
        }

        public override bool Withdraw(double amount)
        {
            if (!base.Withdraw(amount))
            {
                // Withdrawal failed, charge overdraft fee
                Balance = Balance - OverdraftFee;
                Console.WriteLine($"With overdraft, new balance: ${Balance}");
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Overdraft Fee: ${OverdraftFee}";
        }
    }
}