using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface INotification
    {
        void sendMessage(string message);
        string notificationType { get; set; }
    }

    class SMSNotification : INotification
    {
        public void sendMessage(string message)
        {
            Console.WriteLine($"SMS :{message}");
        } 
        public string notificationType { get; set; }
    }
    class PushNotification : INotification
    {
        public void sendMessage(string message)
        {
            Console.WriteLine($"Push Notification :{message}");
        }
        public string notificationType { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Message : ");
            string message = Console.ReadLine();
            INotification smsNotification = new SMSNotification();
            smsNotification.sendMessage(message);
            smsNotification.notificationType = "SMS";
            Console.WriteLine($"{ smsNotification.notificationType}");
            INotification pushNotification = new PushNotification();
            pushNotification.sendMessage(message);
            pushNotification.notificationType = "Push";
            Console.WriteLine($"{pushNotification.notificationType}");
        }
    }
}
