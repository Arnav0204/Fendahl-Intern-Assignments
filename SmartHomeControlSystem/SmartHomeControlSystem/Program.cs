using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartHomeControlSystem
{
    abstract class SmartDevice
    {
        public abstract void TurnOn();
        public void TurnOn(int duration)
        {
            TurnOn();
            Console.WriteLine($"Device will be on for {duration} seconds.");
            TurnOff();
        }
        public abstract void TurnOff();
    }

    // Smart Light class
    class SmartLight : SmartDevice
    {
        public override void TurnOn()
        {
            Console.WriteLine("Smart Light is turned on.");
        }
        public override void TurnOff()
        {
            Console.WriteLine("Smart Light is turned off.");
        }
    }

    // Smart AC class
    class SmartAC : SmartDevice
    {
        public override void TurnOn()
        {
            Console.WriteLine("Smart AC is turned on.");
        }
        public override void TurnOff()
        {
            Console.WriteLine("Smart AC is turned off.");
        }
    }

    // Smart TV class
    class SmartTV : SmartDevice
    {
        public override void TurnOn()
        {
            Console.WriteLine("Smart TV is turned on.");
        }
        public override void TurnOff()
        {
            Console.WriteLine("Smart TV is turned off.");
        }
    }

    class Program
    {
        static void Main()
        {
            SmartDevice light = new SmartLight();
            SmartDevice ac = new SmartAC();
            SmartDevice tv = new SmartTV();

            light.TurnOn(5);
            ac.TurnOn(3);
            tv.TurnOn(4);
        }
    }
}

