using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment
{
    class Savings : Account
    {



        public override double Interest()
        {
            return base.Interest() * +balance;
        }


        //constructors
        public Savings(double balance) : base()
        {

            this.balance = balance;
            accountType = "Savings Account";

        }
    }
}

