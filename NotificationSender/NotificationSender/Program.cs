using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSender
{
    abstract class Notification
    {
        internal abstract void sendMessage(string message);

    }

    internal class EmailNotification : Notification
    {
        internal override void sendMessage(string message)
        {
            Console.WriteLine($"Email : {message}");
        }
    }

    internal class PushNotification : Notification
    {
        internal override void sendMessage(string message)
        {
            Console.WriteLine($"Push Notification : {message}");
        }
    }

    internal class SMSNotification : Notification
    {
        internal override void sendMessage(string message)
        {
            Console.WriteLine($"SMS : {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Message : ");
            string message = Console.ReadLine();
            Notification emailNotification = new EmailNotification();
            emailNotification.sendMessage(message);
            Notification pushNotification = new PushNotification();
            pushNotification.sendMessage(message);
            Notification SMSNotification = new SMSNotification();
            SMSNotification.sendMessage(message);
        }
    }
}
