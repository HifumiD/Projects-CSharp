using System;
using System.Globalization;

namespace LogIn 
{
    internal class Program
    {
        static string username = default;
        static string userpassword = default;
        static void Main(string[] args)
        {   //Choice to Log In or Register
            Console.BackgroundColor= ConsoleColor.White;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.Clear();
            intro();
   
            
        }
        

        //This Method registers your Account
        public static void  registration()
        {
            //store data
            Console.WriteLine("Register yourself, Username : ");
             username = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Declare your new Password : ");
             userpassword = Console.ReadLine();
            Console.Clear();

            
            intro();

            
            

        }
        //This Method logs you in
        public static void logIn() 
        {   
            Console.WriteLine("Enter your Username: ");
            string logName = Console.ReadLine();
            Console.Clear();

            if (logName == username) 
            {
                Console.WriteLine("Enter your Password");
                string logPassword = Console.ReadLine();
                Console.Clear();
                if (logPassword == userpassword)
                {
                    Console.WriteLine("You are logged in");
                }
                else //if no option worked , this resttarts everything
                {
                    Console.WriteLine("Wrong Username, press any key to try again");
                    Console.ReadLine();
                    Console.Clear() ;
                    logIn();
                }

            }
            else //if no option worked , this resttarts everything
            {
                Console.WriteLine("Wrong Username, press any key to try again");
                Console.ReadLine();
                Console.Clear();
                logIn();
            }
            
        }

        //This Method asks what to do
        public static void intro() 
        {
            
            Console.WriteLine(" 1 - To Register");
            Console.WriteLine(" 2 - To LogIn");

            string userChoice = Console.ReadLine();
       
            Console.Clear();


            if (userChoice == "1")
            {
                registration();

            }
            else if (userChoice == "2")
            {
                logIn();
            }
            else
            {
                Console.WriteLine("Neither 1 or 2 was selected ");
                Console.WriteLine("Press Enter to go back to retry");
                Console.ReadLine();
                Console.Clear() ;

                intro();
            }


        }


        
    }
}