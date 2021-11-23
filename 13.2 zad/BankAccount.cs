using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2_zad
{
    class BankAccount
    {
        private string accountNumber;
        private string ownerName;
        private decimal accountBalance;
        public string AccountNumber
        {
            set { accountNumber = value; }
            get { return accountNumber; }
        }
        public string OwnerName
        {
            set { ownerName = value; }
            get { return ownerName; }
        }
        public decimal AccountBalance
        {
            set { accountBalance = value; }
            get { return accountBalance; }
        }
        public void MakeDeposit(decimal n)
        {
            AccountBalance += n;
            Console.WriteLine($"Account balance: {AccountBalance}");
        }
        public void MakeWithdrawal(decimal sum)
        {
            if (accountBalance >= sum)
            {
                accountBalance -= sum;
                Console.WriteLine($"Withdrawn funds: {sum}. Funds available on the account: {accountBalance}");
            }
            else
            {
                Console.WriteLine($"Non-Sufficient Funds");
            }
        }
        public BankAccount()
        {
            accountNumber = "";
            ownerName = "";
            accountBalance = 0;
        }
        public BankAccount(string number, string name, decimal balance)
        {
            accountNumber = number;
            ownerName = name;
            accountBalance = balance;
        }
    }
}
