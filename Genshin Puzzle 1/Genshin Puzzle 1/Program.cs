using System;

namespace Genshin_Puzzle_1
{
    internal class Program
    {
        static int a;
        static int b;
        static int c;
        static int d;
        static bool quitGame;
        static string input;
        static void Main(string[] args)
        {
            quitGame = true;
            randomNumbers();
            while (quitGame)
            {

                

                Grid();

                Console.WriteLine("Press A B C or D to change the value");

                 input = Console.ReadLine().ToLower();


                Console.Clear();

                NumberChange();

                CounterRestart();

                if (a == b && b == c && c == d) 
                {
                    Console.WriteLine("You won. Enter R to Quit or anything to repeat");
                    string leave = Console.ReadLine().ToUpper();

                    if (leave != "R")
                    {
                        randomNumbers();
                        
                    }
                    else
                    {
                        quitGame = false;
                    }
                }
            }
        }
        public static void randomNumbers()
        {
            Random random = new Random();
            a = random.Next(0, 4);
            b = random.Next(0, 4);
            c = random.Next(0, 4);
            d = random.Next(0, 4);
        }

        public static void Grid()
        {
            Console.WriteLine("Welcome to the Genshin Puzzle\n\n");

            //grid

            Console.WriteLine("a     b");
            Console.WriteLine("-------");
            Console.WriteLine(a + "     " + b);
            Console.WriteLine("\n\n");


            Console.WriteLine(c + "     " + d);
            Console.WriteLine("-------");
            Console.WriteLine("c     d");
        }

        public static void WinCondition()
        {
            if (a == b && c==d);
            {
                Console.WriteLine("You won. Enter R to restart");
                string leave = Console.ReadLine().ToUpper();

                if (leave != "R")
                {
                    quitGame = false;
                }
            }
        }

        public static void CounterRestart()
        {
            if (a >= 4) 
            {
                a = 1;
            }
            if (b >= 4) 
            {
                b = 1;
            }
            if (c >= 4) 
            {
                c = 1;
            }
            if (d >=4 )
            {
                d = 1;
            }
            
        }

        public static void NumberChange()
        {
            switch (input)
            {
                case "a":
                    a = a + 1;
                    b = b + 1;
                    c = c + 1;
                    break;

                case "b":
                    a = a + 1;
                    b = b + 1;
                    d = d + 1;
                    break;

                case "c":
                    c = c + 1;
                    a = a + 1;
                    d = d + 1;
                    break;

                case "d":
                    b = b + 1;
                    c = c + 1;
                    d = d + 1;
                    break;
            }
        }


    }

}
