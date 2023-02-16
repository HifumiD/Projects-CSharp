using System;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {   // global variables for the scructure
            bool quitGame = true;
            int round = 0;
            string computer = "";


            //loops the game until player pressed 1 at the end
            while (quitGame)

            {   Console.ForegroundColor= ConsoleColor.White; 
                round++;
                Console.WriteLine("Enter Rock Paper Scissors");
                string player = Console.ReadLine().ToUpper();
                Random random= new Random();
                
                //makes sure you entered one of the options
                while (player != "ROCK" && player != "PAPER" &&  player != "SCISSORS")
                {
                    Console.WriteLine("Enter Rock Paper Scissors");
                    player = Console.ReadLine().ToUpper();
                }
                
                Console.Clear();

                //allows the computer to choose a random value
                switch (random.Next(1,4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;

                }

                //displays information
                Console.WriteLine("Player : " + player);
                Console.WriteLine("Computer : " + computer + "\n"); 
                Console.WriteLine("You are on Round :" + round + "\n" );

                // if options for all possible combinations
                if (player == "ROCK" && computer == "SCISSORS" || player == "PAPER" && computer == "ROCK" || player == "SCISSORS" && computer == "PAPER") { Console.WriteLine("Player Wins", Console.ForegroundColor = ConsoleColor.Green); }
                if (player == "ROCK" && computer == "PAPER" || player == "PAPER" && computer == "SCISSORS" || player == "SCISSORS" && computer == "ROCK") { Console.WriteLine("Computer Wins", Console.ForegroundColor = ConsoleColor.Red); }
                if (player == "ROCK" && computer == "ROCK" || player == "PAPER" && computer == "PAPER" || player == "SCISSORS" && computer == "SCISSORS") { Console.WriteLine("Draw", Console.ForegroundColor = ConsoleColor.Yellow); }

                // lets you repeat or leave
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press Enter to repeat    |    Insert 1 to quit the game");

                string option = Console.ReadLine();
                Console.Clear();
                        
                if (option == "1" ) 
                {
                     quitGame = false;
                }

            }
        }
    }
}
