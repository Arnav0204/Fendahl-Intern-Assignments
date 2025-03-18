using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
     class C1
    {
       
        public static void createObject()
        {
            return;
        }
       
    }

    class C2 : C1
    {
        public new static void createObject()
        {
            Console.WriteLine("Hello");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
