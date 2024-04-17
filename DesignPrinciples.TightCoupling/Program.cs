namespace DesignPrinciples.TightAndLooseCoupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService(new EmailService(), new SmsService());
            notificationService.Notify();

            Console.ReadKey();
        }
    }

    public class EmailService
    {
        public void Send()
        {
            Console.WriteLine("Email Sent!!");
        }
    }

    public class SmsService
    {
        public void Send()
        {
            Console.WriteLine("SMS Sent!!");
        }
    }

    public class NotificationService
    {
        // Here There is high coupling as the problem in one of them affect others and the code is poluted
        private readonly EmailService _emailService;
        private readonly SmsService _smsService;

        public NotificationService(EmailService emailService, SmsService smsService)
        {
            _emailService = emailService;
            _smsService = smsService;
        }

        public void Notify()
        {
            _emailService.Send();
            _smsService.Send();
        }
    }
}
