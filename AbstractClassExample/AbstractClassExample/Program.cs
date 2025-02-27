using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    abstract class Printer {
        public abstract void display();
    }

    class LaserJet : Printer {
        public override void display()
        {
            Console.WriteLine("display method from laser jet class");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p1 = new LaserJet();
            p1.display();
        }
    }
}
