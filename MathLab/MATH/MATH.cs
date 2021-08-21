using System;
using System.Text.Json.Serialization;

namespace Lab_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //char ch;
            //bool result;

            ////input character 
            //Console.Write("Would you like to: + - % or * ? ");
            //result = Char.TryParse(Console.ReadLine(), out ch);

            //Console.WriteLine("Input character is {0}", ch);

            char Operation = ' ';
            int LeftHandSide = 0;
            int RightHandSide = 0;
            int result = 0;

            PromptForInput("Please enter the operator: ");
            Operation = GetOperation();
            PromptForInput("Please enter the first digit: ");
            LeftHandSide = GetInput();
            PromptForInput("Please enter the second digit: ");
            RightHandSide = GetInput();

            switch (Operation)
            { 
                case '/':
                result = DivideDigits(LeftHandSide, RightHandSide);
                break;
            case '*':
                result = MultiplyDigits(LeftHandSide, RightHandSide);
                break;
            case '-':
                result = SubtractDigits(LeftHandSide, RightHandSide);
                break;
            case '+':
                result = AddDigits(LeftHandSide, RightHandSide);
                break;
            default:
                result = 0;
                Console.WriteLine("Have a good day. ");
                return;
            }
            Console.WriteLine($"The result is {result}.");
        }
            static char GetOperation()
            {
            char s;
            bool st;
            Console.Write("   Would you like to: + - % or * ? ");
            st = Char.TryParse(Console.ReadLine(), out s);
            return s;    
             }

        static int GetInput()
            {
                return int.Parse(Console.ReadLine());
            }

            static void PromptForInput(string message)
            {
                Console.Write(message);
            }

            static int MultiplyDigits(int lhs, int rhs)
            {
                return lhs * rhs;
            }

            static int DivideDigits(int lhs, int rhs)
            {
                return lhs / rhs; 
            }

            static int SubtractDigits(int lhs, int rhs)
            {
                return lhs - rhs; 
            }

            static int AddDigits(int lhs, int rhs)
            {
                return lhs + rhs; 
            }

    }
}
