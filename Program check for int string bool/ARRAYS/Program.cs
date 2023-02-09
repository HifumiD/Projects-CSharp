using System;
using System.Globalization;

namespace ARRAYS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;

            Console.WriteLine("Input any Value or press 5 to quit");
            string userInput = Console.ReadLine();

            Console.WriteLine("Press 1 for String, Press 2 for integer, Press 3 for Boolean");
            string selection = Console.ReadLine();
            int conversion = int.Parse(selection);
            if (userInput == "5")
            {
                quit = true;
            }
           
                switch (conversion)
                {
                    case 1:
                        bool test1 = int.TryParse(userInput, out var day1);
                        if (test1)
                        {
                            Console.WriteLine("Not a String");
                        }
                        else
                        {
                            Console.WriteLine("It is a String");
                        }

                        break;


                    case 2:
                        bool test2 = int.TryParse(userInput, out var day);
                        if (test2)
                        {
                            Console.WriteLine("It is an Int");
                        }
                        else
                        {
                            Console.WriteLine("It is not an Int");
                        }


                        break;

                    case 3:
                        if (userInput == "true" || userInput == "false")
                        {
                            Console.WriteLine("It is a Boolean");
                        }
                        else
                        {
                            Console.WriteLine("it is not a Boolean");
                        }
                    

                    break;

                    default:
                    {
                        Console.WriteLine("Could not detect valid Input");
                        break;
                        
                    } 
                    
                    

                }   

                    

            

             


        }
    }
}
