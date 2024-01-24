using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    /// <summary>
    /// Encapsulation hides the internal state and functionality of an object and only allows access thru public
    /// set of functions/variables/properties.
    /// </summary>
    class Bank
    {
        public long AccountNumber;
        //public string Name;

        // auto-implemented property -
        // this is the short-hand property and does the same thing as GetBalance() and SetBalance()
        public string Name { get; set; }

        // hiding class data by declaring the variable as private (by default the member is private)
        int Balance;

        public void Deposit()
        {

        }

        //public getter method
        public int GetBalance()
        {
            return Balance;
        }

        //public setter method
        public void SetBalance(int balance)
        {
            //Validation while setting the balance to check if its positive else it will throw an exception.
            if (balance > 0)
                this.Balance = balance;
            else
                throw new Exception("Please pass a positive value");
        }

        public void Withdrawal()
        {

        }
    }
}
