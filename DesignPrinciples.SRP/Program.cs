using DesignPrinciples.SRP;
using DesignPrinciples.SRP.After;

namespace DesignPrinciples.SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestWithoutSRP();
            TestWithSRP();

            Console.ReadKey();
        }

        private static void TestWithoutSRP()
        {
            Before.BankAccount bankAccount = new Before.BankAccount("Mohamed", "moo@gmail.com", 4526m);
            bankAccount.MakeTransaction(-452);
        }

        private static void TestWithSRP()
        {
            After.BankAccount bankAccount = new After.BankAccount("Mohamed", "moo@gmail.com", 4526m);
            BankAccountService bankAccountService = new BankAccountService();
            bankAccountService.Withdraw(bankAccount, 452);
        }
    }
}
