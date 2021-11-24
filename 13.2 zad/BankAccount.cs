using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2_zad
{
    class BankAccount
    {
     
        public string AccountNumber
        {
            get;set;
        }
        public string OwnerName
        {
            get; set;
        }
        public decimal AccountBalance
        {
            get; set;
        }
        public void MakeDeposit(decimal n)
        {
            AccountBalance += n;
            Console.WriteLine($"Account balance: {AccountBalance}");
        }
        public void MakeWithdrawal(decimal sum)
        {
            if (AccountBalance >= sum)
            {
                AccountBalance -= sum;
                Console.WriteLine($"Withdrawn funds: {sum}. Funds available on the account: {AccountBalance}");
            }
            else
            {
                Console.WriteLine($"Non-Sufficient Funds");
            }
        }
        public BankAccount()
        {
            AccountNumber = "";
            OwnerName = "";
            AccountBalance = 0;
        }
        public BankAccount(string number, string name, decimal balance)
        {
            AccountNumber = number;
            OwnerName = name;
            AccountBalance = balance;
        }
    }
}
