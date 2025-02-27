using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    internal class BaseMember { 
     internal void display()
        {
            Console.WriteLine("display method from base class");
        } 
    }

    internal class DerivedMember : BaseMember
    {
        internal void display()
        {
            Console.WriteLine("display method from derived class");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BaseMember obj1 = new BaseMember();
            obj1.display();
            BaseMember obj2 = new DerivedMember();
            obj2.display();
            DerivedMember obj3 = new DerivedMember();
            obj3.display();
        }
    }
}
