using System;

namespace _13._2_zad
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            string number = arr[0];
            string name = arr[1] + " " + arr[2];
            decimal balance = decimal.Parse(arr[3]);
            BankAccount person1 = new BankAccount(number, name, balance);
            while (true)
            {
                string comment = Console.ReadLine();
                if (comment == "End")
                {
                    break;
                }
                string[] deposit = comment.Split();
                string depo = deposit[0];
                decimal moneydepo = decimal.Parse(deposit[1]);
                if (depo == "Deposit")
                {
                    person1.MakeDeposit(moneydepo);
                }
                else
                {
                    person1.MakeWithdrawal(moneydepo);
                }
            }
        }
    }
}
