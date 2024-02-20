using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Virtual_Overriding_and_new_MatthewVargas
{
    internal class RetirementAccount : SavingsAccount
    {
        public RetirementAccount(string name, double balance, double interest) : base(name, balance, interest)
        {
        }

        public new bool Withdraw(double amount)
        {
            Console.WriteLine("Sorry, you cannot withdraw from a retirement account");
            return false;
        }
    }
}