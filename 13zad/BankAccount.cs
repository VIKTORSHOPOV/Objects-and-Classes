using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13zad
{
    class BankAccount
    {
        public string AcccountNumber { get; set; }
        public string AccountOwner { get; set; }
        public decimal AccountBalance { get; set; }

        public void MakeDeposit(decimal cash)
        {
            AccountBalance += cash;
            Console.WriteLine($"Account balance: {AccountBalance}");
        }

        public void MakeWithdraw(decimal cash)
        {
            if(AccountBalance >= cash)
            {
                AccountBalance -= cash;
                Console.WriteLine($"Withdrawn funds: {cash}. Funds available on the account: {AccountBalance}");
            }
        }
    }
}
