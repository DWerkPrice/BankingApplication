using System;

namespace BankingLibrary { 

    public class  Account{

        private static int NextAcctNbr = 1; // to assign first account number we start at some number in this case first customer will be 1
        private const int AcctNbrInc = 9;  // to increment account number by some number to create new account number as unique
                                           // defined as a constant because it will never change
        public int AcctNbr { get; private set; }
        public string Description { get; set; } = "Account";
        public decimal Balance { get; set; }

        private int AttemptsToOverdraw = 0;
 
        private bool IsAmountGTZero(decimal amount) {
            return (amount <= 0) ? false : true;  // use the ternary method instead of if then as long as true or false is all we have to do
        }
        

        public void Deposit(decimal amount) {
            if (IsAmountGTZero(amount)) {
                Balance += amount;
            }
        }
        private bool IsSufficientFunds(decimal amount) {
        //    return (Balance >= amount) ? true: false;
           if (Balance>= amount) {
                return true;
           }
           AttemptsToOverdraw++;
           return false;
        }
        public bool Withdraw(decimal amount) {
            if (IsAmountGTZero(amount) && IsSufficientFunds(amount)) {
                    Balance -= amount;
                    return true;
            }
            return false;

        }
        
        public void Transfer(decimal amount , Account toAccount ) {
            if (this.Withdraw(amount)) {
               toAccount.Deposit(amount);
            }
        }

        public override string ToString() {
            return $"Acctnbr={AcctNbr}, Desc={Description}, Bal={Balance}"; 
        }
        public void debug() {
            Console.WriteLine(this); // gets the line abobe after return as this
        }
        public Account() {   // sets up the account number of the new account coming in
            this.AcctNbr = NextAcctNbr;
            NextAcctNbr += AcctNbrInc;
        }

    }
}

