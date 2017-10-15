using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment
{
    abstract class Client
    {
        public string firstName;
        public string lastName;



        public virtual string ClientInfo()
        {
            string clientinfo = ("Account Holder: " + firstName + " " + lastName);
            return clientinfo;
        }
    }
}
