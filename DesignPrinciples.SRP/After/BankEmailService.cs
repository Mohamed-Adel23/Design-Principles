using System.Xml.Linq;

namespace DesignPrinciples.SRP.After
{
    public class BankEmailService
    {
        public void Send(BankAccount bankAccount, string transactionMessage)
        {
            Console.WriteLine(
             $"\n\n\t\t To: {bankAccount.Email}" +
             $"\n\t\t Subject: Fake Bank Account Activity" +
             $"\n\n\t\t Dear {bankAccount.Name}," +
             $"\n\n\t\t\t A recent activity on your account occurs at {DateTime.Now.ToString("yyyy-MM-dd hh:mm")}" +
             "\n\t\t\t\t ===> {0}" +
             $"\n\n\t\t Thank You,\n\t\t Fake Bank." +
             $"\n\n\t\t--------------------------- ", transactionMessage);
        }
    }
}
