using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment
{
    class Account
    {
        //fields
        private string firstName;
        private string lastName;

        private double interestRate;

        private double accountNumber;
        protected string accountType;

        protected double balance;
        protected double deposit;
        protected double withdrawal;

        //properties

        public double InterestRate
        { get { return this.interestRate; } }

        public string AccountType
        { get { return this.accountType; } }

        public double Withdrawal
        {
            get { return this.withdrawal; }
            set { this.withdrawal = value; }
        }
        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }
        public double AcctNumber
        { get { return this.accountNumber; } }

        public double Bal
        { get { return this.balance; } }

        //constructors



        public Account()
        {


            firstName = "Nathan";
            lastName = "Ratner";
        }

        //methods

        public virtual double AccountNumb()
        {

            this.accountNumber = 1122120;
            return accountNumber;
        }


        public virtual double Balance()
        {
            balance = balance + deposit - withdrawal;
            deposit = 0;
            withdrawal = 0;
            return balance;
        }

        public virtual double Interest()
        {
            return interestRate = 0.10d;
        }

        public virtual double DepositBalance(double input)
        {
            deposit = input;
            withdrawal = 0;
            balance = balance + deposit - withdrawal;
            return balance;
        }


        public virtual double WithBalance(double input)
        {
            withdrawal = input;
            deposit = 0;
            balance = balance + deposit - withdrawal;
            return balance;
        }



        //displays menu
        public virtual void DisplayMenu()
        {
            Console.WriteLine("First American Bank\nHello " + firstName + " " + lastName);
            Console.WriteLine("Please choose from the options below:\n1.View Client Info\n2.View Account Balance:");
            Console.WriteLine("     2A.Checking\n     2B.Savings");
            Console.WriteLine("3.Deposit Funds:\n     3A.Checking\n     3B.Savings");
            Console.WriteLine("4.Withdraw Funds:\n     4A.Checking\n     4B.Savings");
            Console.WriteLine("5.Exit");
        }
        //client info





        public virtual string ClientInfo()
        {
            string clientinfo = ("Account Holder: " + firstName + " " + lastName + " Account Number: " + AccountNumb());
            return clientinfo;
        }
    }
}
