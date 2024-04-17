namespace DesignPrinciples.SRP.After
{
    public class BankAccountService
    {
        private string transactionMessage = "";

        private void SendEmail(BankAccount bankAccount)
        {
            BankEmailService bankEmailService = new BankEmailService();
            bankEmailService.Send(bankAccount, this.transactionMessage);
        }

        public void Withdraw(BankAccount bankAccount, decimal amount)
        {
            amount = Math.Abs(amount);
            if (bankAccount.Balance < amount)
            {
                transactionMessage =
                $"OVERDRAFT when trying to withdraw " +
                $"{Math.Abs(amount).ToString("C2")}," +
                $" current balance {bankAccount.Balance.ToString("C2")}";
            }
            else
            {
                bankAccount.Balance -= amount;
                transactionMessage =
                   $"OK Withdraw {Math.Abs(amount).ToString("C2")}" +
                   $", current balance {bankAccount.Balance.ToString("C2")}";
            }
            // Here the current method is not responsible for sending email
            // but just inform to send the email
            this.SendEmail(bankAccount);
        }

        public void Deposite(BankAccount bankAccount, decimal amount)
        {
            amount = Math.Abs(amount);
            bankAccount.Balance += amount;

            transactionMessage =
                $"OK Deposit {amount.ToString("C2")}" +
                $", current balance {bankAccount.Balance.ToString("C2")}";
            // Here the current method is not responsible for sending email
            // but just inform to send the email
            this.SendEmail(bankAccount);
        }
    }
}
