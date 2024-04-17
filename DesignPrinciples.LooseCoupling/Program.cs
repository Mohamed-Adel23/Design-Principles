namespace DesignPrinciples.LooseCoupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationService service = NotificationFactory.Create(NotificationMode.MESSANGER);

            NotificationService notify = new NotificationService(service);
            notify.Notify();

            Console.ReadKey();
        }
    }

    public interface INotificationService
    {
        void Send();
    }

    public enum NotificationMode
    {
        EMAIL,
        SMS,
        WHATSAPP, 
        MESSANGER
    }

    public class NotificationFactory
    {
        public static INotificationService Create(NotificationMode mode)
        {
            switch(mode)
            {
                case NotificationMode.EMAIL:
                    return new EmailService();
                case NotificationMode.SMS:
                    return new SmsService();
                case NotificationMode.WHATSAPP:
                    return new WhatsService();
                case NotificationMode.MESSANGER:
                    return new MessangerService();
                default:
                    return new EmailService();
            }
        }
    }

    public class EmailService: INotificationService
    {
        public void Send()
        {
            Console.WriteLine("Email Sent!!");
        }
    }

    public class SmsService: INotificationService
    {
        public void Send()
        {
            Console.WriteLine("SMS Sent!!");
        }
    }

    public class WhatsService : INotificationService
    {
        public void Send()
        {
            Console.WriteLine("Whats App Message Sent!!");
        }
    }

    public class MessangerService : INotificationService
    {
        public void Send()
        {
            Console.WriteLine("Messanger Message Sent!!");
        }
    }

    public class NotificationService
    {
        private readonly INotificationService _service;
        public NotificationService(INotificationService service)
        {
            _service = service;
        }
        // Here The Notification will work based on the upcoming service
        public void Notify()
        {
            _service.Send();    
        }
    }
}
