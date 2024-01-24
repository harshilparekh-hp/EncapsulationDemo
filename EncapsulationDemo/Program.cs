using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.AccountNumber = 123;
            // bank.Balance // you cant access the balance amount as its hidden/private.
            bank.Name = "CIBC Bank";
            bank.SetBalance(500);
            Console.WriteLine("My balance is : {0}", bank.GetBalance().ToString());
            bank.SetBalance(150);
            Console.WriteLine("My balance is : {0}", bank.GetBalance().ToString());
            Console.WriteLine("name of the bank: {0}", bank.Name);

            bank.Withdrawal();

            Console.ReadKey();
        }
    }
}
