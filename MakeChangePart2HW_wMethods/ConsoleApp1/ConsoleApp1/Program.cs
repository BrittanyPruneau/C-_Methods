using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
        double price = PurchaseAmount("Enter a purchase amount: ");
            Console.WriteLine("Your purchase amount is:  $ {0} ", price);
        double payment = PaymentAmount("How much will you pay for that? ");
            Console.WriteLine("The amount you have paid is $ {0}", payment);
        }
    


        static double PurchaseAmount(string LookingFor)
        {
            Console.WriteLine(LookingFor);
            double Price = double.Parse(Console.ReadLine()); 
            return Price; 
        }

        static double PaymentAmount(string customerSays)
        {
            Console.WriteLine(customerSays);
            double payment = double.Parse(Console.ReadLine());
            return payment; 
        }

    }
}

