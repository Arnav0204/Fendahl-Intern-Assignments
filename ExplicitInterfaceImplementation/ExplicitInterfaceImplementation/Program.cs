using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceImplementation
{
    interface Ione
    {
        void show();
    }
    interface Itwo {
     void show();
    }

    class c1 : Ione, Itwo
    {
        public void show()
        {
            Console.WriteLine("From class");
        }
        void Ione.show()
        {
            Console.WriteLine("From first interface");
        }
        void Itwo.show()
        {
            Console.WriteLine("From second interface");
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            c1 c1 = new c1();
            c1.show();
            Ione obj1 = new c1();
            obj1.show();
            Itwo obj2 = new c1();
            obj2.show();
        }
    }
}
