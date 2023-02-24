using System;

namespace Simple_Calculator
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Welcome to the Calculator");

            //loops until quit is false
            bool quit = true;
            while (quit)
            {
                do
                {
                    Console.WriteLine("Enter one of the following : + -  * / ");

                    //choose + / - or *
                    input = Console.ReadLine();
                    Console.Clear();
                }
                while (input != "+" && input != "-" && input != "*" && input != "/");
                

                switch (input)
                {
                 case "+":
                 Console.WriteLine("You are going to add");
                 break;

                 case "-":
                 Console.WriteLine("You are going to subtract");
                 break;

                 case "*":
                 Console.WriteLine("You are going to multiply");
                 break;

                 case "/":
                 Console.WriteLine("You are going to divide");
                 break;
                }

                
                //enter the numbers you want to calculate
                Console.WriteLine("Enter first number");

                    string inp1 = Console.ReadLine();
                    int num1 = int.Parse(inp1);
 
                Console.WriteLine("Enter second number");

                    string inp2 = Console.ReadLine();
                    int num2 = int.Parse(inp2);
                
                Console.Clear();

                // does the calculation depending on your character
                    if (input == "+")
                    {
                        Console.WriteLine("The sum is {0}", num1 + num2);
                    }
                    if (input == "-")
                    {
                        Console.WriteLine("The subtraction is {0}", num1 - num2);
                    }
                    if (input == "/")
                    {
                        double sum = num1 / num2;
                        Console.WriteLine("The division is {0}", (double)sum);
                    }
                    if (input == "*")
                    {
                        Console.WriteLine("The multiplication is {0}", num1 * num2);
                    }
                //press enter to repeat
                Console.ReadLine();


            }


        }
    }
}
