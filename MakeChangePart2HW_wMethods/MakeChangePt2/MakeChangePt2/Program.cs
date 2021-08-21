using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSTRUCTIONS 1 AND 2 
            // (20 points) A method that a) prompts for the purchase amount, b) accepts the purchase amount, c) converts the purchase amount to a double, and d) returns that double.
            // (20 points) A method that a) prompts for the payment amount, b) accepts the payment amount, c) converts the payment amount to a double, and d) returns that double.
            //  
            //double cost = PurchaseAmountInstructions1and2();
            // Console.WriteLine("Your purchase amount is:  $ {0} ", cost);

            // 
            // double payment = PaymentAmountInstructions1and2();
            // Console.WriteLine("The amount you have paid is $ {0}", payment);

            // INSTRUCTIONS 3 
            // (30 points) A method that accepts two parameters: the purchase amount and the payment amount. This method will compute the change due, print out the change due, and print out how many of each denomination should be given to the customer.
            double cost = PurchaseAmount("Enter a purchase amount: ");
            Console.WriteLine("Your purchase amount is:  $ {0} ", cost);

            double payment = PaymentAmount("How much will you pay for that? ");
            Console.WriteLine("The amount you have paid is $ {0}", payment);

            var change = changeDue(cost, payment);  // interesting observation: the method returns AND PRINTS THE 
                                                    //RETURNED VALUES without even have to print them OR save them into a variable.  

            // INSTRUCTIONS 4 (20 points) Right now, the first two methods (items 1 and 2 above) don't take any parameters. 
            // Each one outputs a hard-coded string for its prompt, and each one returns a double. Combine these two methods into a 
            // single method which takes one parameter: the string to prompt the user with. Instead of calling the two methods in items 1 and 2, have  Main() call this new method two different times, with two different string prompts - once prompting for the purchase amount, and the second time prompting for the payment amount.
            string request1 = ("How much will your items cost?");
            string request2 = ("How much will you pay for those items?");

            (double secondcost, double secondPayment) = secondRequest(request1, request2);
            Console.WriteLine("The amount you owe: $ {0} and the amount you have paid: $ {1}", secondcost, secondPayment); 
        }

        public static (double, double) secondRequest(string request1, string request2)
        {
            Console.WriteLine(request1);
            double secondCost = double.Parse(Console.ReadLine());
            Console.WriteLine(request2);
            double secondPayment = double.Parse(Console.ReadLine());
            return (secondCost, secondPayment);        
        }

        public static (int twenties, int tens, int fives, int ones, int quarters, int dimes, int nickles, int pennies) changeDue(double cost, double payment)
        {

            double change = payment - cost;
            Console.WriteLine("Change Due: $" + change);  // concatenation

            int twenties = (int)(change / 20);
            Console.WriteLine("Twenties Due: " + twenties);
            change = change - (twenties * 20);

            int tens = (int)(change / 10);
            Console.WriteLine("Tens Due:" + tens);
            change = change - (tens * 10);

            int fives = (int)(change / 5);
            Console.WriteLine("Fives Due:" + fives);
            change = change - (fives * 5);

            int ones = (int)(change / 1);
            Console.WriteLine("Ones Due:" + ones);
            change = change - ones;

            int quarters = (int)(change * 100) / 25;  // converted float change into an int
            Console.WriteLine("Quarters Due: " + quarters);
            change = change - (float)(quarters * .25);

            int dimes = (int)(change * 100) / 10;  // converted float change into an int
            Console.WriteLine("Dimes Due: " + dimes);
            change = change - (float)(dimes * .10);

            int nickles = (int)(change * 100) / 5;  // converted float change into an int
            Console.WriteLine("Nickles Due: " + nickles);
            change = change - (float)(nickles * .05);

            int pennies = (int)(change * 100); // converted float change into an int 
            Console.WriteLine("Pennies Due: " + pennies);
            change = change - (float)(pennies * .01);


            return (twenties, tens, fives, ones, quarters, dimes, nickles, pennies);

        }


        public static double PurchaseAmount(string LookingFor)
        {
            Console.WriteLine(LookingFor);
            double cost = double.Parse(Console.ReadLine());
            return cost;
        }

        public static double PaymentAmount(string customerSays)
        {
            Console.WriteLine(customerSays);
            double payment = double.Parse(Console.ReadLine());
            return payment;
        }

        // 
        // public static double PurchaseAmountInstructions1and2()
        //{
        // Console.WriteLine("How much are your items going to cost?"); 
        // double cost1 = double.Parse(Console.ReadLine()); 
        // return; 
        //}

        // 
        // public static double PaymentAmountInstructions1and2()
        //{
        // Console.WriteLine("How much are you paying for those items?"); 
        // double payment1 = double.Parse(Console.ReadLine()); 
        // return; 
        //}

    }
}

// (30 points) A method that accepts two parameters: the purchase amount and the payment amount. This method will compute the change due, 
// print out the change due, and print out how many of each denomination should be given to the customer.

// method expects double price and double payment . It promises to return a double. 