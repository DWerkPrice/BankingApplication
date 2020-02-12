using System;

namespace BankingLibrary
{
    public class Account {
        public string AcctNbr {get;set;}
        public string Description { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount) {
            Balance += amount;

        }
        public void Withdraw(decimal amount) {
            Balance -= amount;
        }
        public void Transfer(decimal amount, Account toAccount, Account fromAccount) {
            fromAccount.Withdraw(amount);
            toAccount.Deposit(amount);
        }
        public Account() { }

    }

}

