﻿namespace DesignPrinciples.SRP.Before
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }
        public BankAccount(string name, string email, decimal balance)
        {
            Name = name;
            Email = email;
            Balance = balance;
        }

        public void MakeTransaction(decimal amount) // amount +/-
        {
            var transactionMessage = "";

            // handle withdraw
            if (amount < 0)
            {
                if (Balance < Math.Abs(amount))
                {
                    transactionMessage =
                    $"OVERDRAFT when trying to withdraw " +
                    $"{Math.Abs(amount).ToString("C2")}," +
                    $" current balance {Balance.ToString("C2")}";
                }
                else
                {
                    this.Balance += amount;
                    transactionMessage =
                       $"OK Withdraw {Math.Abs(amount).ToString("C2")}" +
                       $", current balance {Balance.ToString("C2")}";
                }
            }
            else
            {
                // handle deposit
                if (amount > 0)
                {
                    this.Balance += amount;

                    transactionMessage =
                        $"OK Deposit {amount.ToString("C2")}" +
                        $", current balance {Balance.ToString("C2")}";
                }
            }

            // mock process for sending email
            Console.WriteLine(
             $"\n\n\t\t To: {Email}" +
             $"\n\t\t Subject: Fake Bank Account Activity" +
             $"\n\n\t\t Dear {Name}," +
             $"\n\n\t\t\t A recent activity on your account occurs at {DateTime.Now.ToString("yyyy-MM-dd hh:mm")}" +
             "\n\t\t\t\t ===> {0}" +
             $"\n\n\t\t Thank You,\n\t\t Fake Bank." +
             $"\n\n\t\t--------------------------- ", transactionMessage);
        }
    }
}
