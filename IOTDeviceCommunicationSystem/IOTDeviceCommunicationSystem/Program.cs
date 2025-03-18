using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTDeviceCommunicationSystem
{

    public interface IDevice
    {
        void Connect();
        void SendData(string data);
        string ReceiveData();
    }

    public class TemperatureSensor : IDevice
    {
        public void Connect()
        {
            Console.WriteLine("Temperature Sensor connected.");
        }

        public void SendData(string data)
        {
            Console.WriteLine($"Temperature Sensor sending data: {data}");
        }

        public string ReceiveData()
        {
            string data = "Temperature: 25°C";
            Console.WriteLine($"Temperature Sensor received data: {data}");
            return data;
        }
    }

    public class MotionSensor : IDevice
    {
        public void Connect()
        {
            Console.WriteLine("Motion Sensor connected.");
        }

        public void SendData(string data)
        {
            Console.WriteLine($"Motion Sensor sending data: {data}");
        }

        public string ReceiveData()
        {
            string data = "Motion detected!";
            Console.WriteLine($"Motion Sensor received data: {data}");
            return data;
        }
    }
    public class LightController : IDevice
    {
        private bool isLightOn = false;

        public void Connect()
        {
            Console.WriteLine("Light Controller connected.");
        }

        public void SendData(string data)
        {
            if (data.ToLower() == "on")
            {
                isLightOn = true;
                Console.WriteLine("Light turned ON.");
            }
            else if (data.ToLower() == "off")
            {
                isLightOn = false;
                Console.WriteLine("Light turned OFF.");
            }
            else
            {
                Console.WriteLine($"Light Controller received unknown command: {data}");
            }
        }

        public string ReceiveData()
        {
            string status = isLightOn ? "Light is ON" : "Light is OFF";
            Console.WriteLine($"Light Controller status: {status}");
            return status;
        }
    }

    internal class Program
    {
         static void Main()
        {
            IDevice tempSensor = new TemperatureSensor();
            tempSensor.Connect();
            tempSensor.SendData("Temperature: 30°C");
            tempSensor.ReceiveData();

            IDevice motionSensor = new MotionSensor();
            motionSensor.Connect();
            motionSensor.SendData("Motion event at 12:30 PM");
            motionSensor.ReceiveData();

            IDevice lightController = new LightController();
            lightController.Connect();
            lightController.SendData("on");
            lightController.ReceiveData();
            lightController.SendData("off");
            lightController.ReceiveData();
        }
    }
}
