using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment
{
    class Checking : Account
    {


        //constructors

        public Checking(double balance) : base()
        {


            this.balance = balance;
            accountType = "Checking Account";
        }

        //methods

        public override double Interest()
        {
            return base.Interest() * +balance;
        }
    }
}


