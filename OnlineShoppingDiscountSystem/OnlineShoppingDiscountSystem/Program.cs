using System;

namespace OnlineShoppingDiscountSystem
{
    
    abstract class Discount
    {
        public abstract decimal CalculateDiscount(decimal price);
    }

    
    class SeasonalDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price)
        {
            return price * 0.05m;  
        }
    }

    class FestivalDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price)
        {
            return price * 0.15m;  
        }
    }

    
    class MembershipDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price)
        {
            return price * 0.25m;  
        }
    }

    internal class Program
    {
        static void Main()
        {
            decimal originalPrice = 5000m;

         
            Discount seasonal = new SeasonalDiscount();
            Discount festival = new FestivalDiscount();
            Discount membership = new MembershipDiscount();

            decimal seasonalDiscount = seasonal.CalculateDiscount(originalPrice);
            decimal festivalDiscount = festival.CalculateDiscount(originalPrice);
            decimal membershipDiscount = membership.CalculateDiscount(originalPrice);

            
            Console.WriteLine("======= Online Shopping Discount System =======");
            Console.WriteLine($"Original Price          : Rs. {originalPrice}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Seasonal Discount (5%) : Rs. {seasonalDiscount}");
            Console.WriteLine($"Festival Discount (15%) : Rs. {festivalDiscount}");
            Console.WriteLine($"Membership Discount (25%): Rs. {membershipDiscount}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Final Price After Seasonal Discount  : Rs. {originalPrice - seasonalDiscount}");
            Console.WriteLine($"Final Price After Festival Discount  : Rs. {originalPrice - festivalDiscount}");
            Console.WriteLine($"Final Price After Membership Discount: Rs. {originalPrice - membershipDiscount}");
            Console.WriteLine("===============================================");
        }
    }
}
