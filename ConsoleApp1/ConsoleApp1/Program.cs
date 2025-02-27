using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Coffee
    {
        

        internal void selectCoffee(FilterCoffee coffee) 
        {
            Console.WriteLine("filter coffee selected");
        }

        internal void selectCoffee(BrewFilterCoffee coffee)
        {
            Console.WriteLine("brew filter coffee selected");
        }



        internal void selectCoffee(FrenchPressCoffee coffee)
        {
            Console.WriteLine("french press coffee selected");
        }


    }

    internal class FilterCoffee
    {

    }

    internal class BrewFilterCoffee
    {

    }

    internal class FrenchPressCoffee
    {

    }

    

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1 for filter coffee");
            Console.WriteLine("enter 2 for Brew filter coffee");
            Console.WriteLine("enter 3 for French Press filter coffee");
            Console.Write("enter your choice : ");
            int choice = int.Parse(Console.ReadLine());
            Coffee coffee = new Coffee();
            switch(choice)
            {
                case 1: coffee.selectCoffee(new FilterCoffee()); break;
                case 2: coffee.selectCoffee(new BrewFilterCoffee()); break;
                case 3: coffee.selectCoffee(new FrenchPressCoffee()); break;
                default:break;
            }
        }
    }
}
