using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary{

    public class InterestAccount : Account {

        public decimal InterestRate { get; private set; }

        public void CalculateInterest(int Months) {
            var interest = this.Balance * (this.InterestRate / 12) * Months;
            Deposit(interest);
            Console.WriteLine($"Calculated interest is {interest}");
        }
        //        public InterestAccount(decimal interestRate) : this() {// until we added :this() which calls our contructor account would not have been set
        //           InterestRate = interestRate;
        //  passing a double and then converting to decimal prevents having to have that m in program.class on pass

        public InterestAccount(double interestRate) : this(){// until we added :this() which calls our contructor account would not have been set
            InterestRate = Convert.ToDecimal(interestRate);
        }
        public override string ToString() {
 //           return base.ToString() + $" IntRate={InterestRate}"; // base calls the ToString() from Account.cs and adds to it the interest rate
            return $"{base.ToString()},  IntRate={InterestRate} ";
        }
    
        public InterestAccount() : base() {
            this.Description = "Interest Account";
        }
    }
}
