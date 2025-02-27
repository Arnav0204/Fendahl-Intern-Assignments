using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    internal class Printer
    {
        internal Printer() { }
        internal virtual void display()
        {
            Console.WriteLine("dimension is 5*5");
        }
        internal virtual void print()
        {
           Console.WriteLine("print method from Printer class");
        }


    }

    internal class LaserJet : Printer {
        internal sealed override void display()
        {
           Console.WriteLine("dimension is 10*10");
        }
        internal override void print()
        {
            Console.WriteLine("print method from LaserJet class");
        }

    }

    internal class InkJet : LaserJet
    {
        
        internal override void print()
        {
            Console.WriteLine("print method from InkJet class");
        }

        internal new void display()
        {
            Console.WriteLine("dimension is 15*15");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Printer obj1 = new Printer();
            obj1.display();
             obj1 = new LaserJet();
            obj1.display();
            InkJet obj2=new InkJet();
            obj2.display();
        }
    }
}
