using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory
{
    internal class ProductCategory
    {
        private double price;
        internal ProductCategory(double price) {
            this.price = price;
        }
        internal void calculatePrice()
        {
            Console.WriteLine($"price without tax and discount : {this.price}");
        }
        internal void calculatePrice(double tax)
        {
            double finalPrice = this.price + ((tax / 100) * this.price);
            Console.WriteLine($"price after tax : {finalPrice}");
        }
        internal void calculatePrice(double tax,double discount)
        {
            double finalPrice = this.price + ((tax / 100) * this.price);
            finalPrice-=discount;
            Console.WriteLine($"price after tax and discount : {finalPrice}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of Product : ");
            double cost = double.Parse( Console.ReadLine() );
            ProductCategory productCategory = new ProductCategory(cost);
            Console.WriteLine("case 1 : normal price :");
            productCategory.calculatePrice();
            Console.WriteLine("case 2 : price after tax :");
            productCategory.calculatePrice(10);
            Console.WriteLine("case 3 : price after tax and discount :");
            productCategory.calculatePrice(10,2000);
        }
    }
}
