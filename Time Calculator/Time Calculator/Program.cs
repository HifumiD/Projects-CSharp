using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace Time_Calculator
{
    internal class Program
    {
        //global variables needed for program to work

        public static bool quit = false;

        public static int hour;
        public static int minutes;
        public static int hour2;
        public static int minutes2;
        public static int calculationHours;
        public static int calculationMin;

        
        static void Main(string[] args)
        {
            Console.BackgroundColor= ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            
            while (quit == false)
            {
                
                Console.Clear();
                Console.WriteLine();

                try
                {
                    checkTime1();
                    Console.WriteLine("\n");
                    checkTime2();

                    calculation();
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("The time is {0} hours and {1} minutes ", calculationHours, calculationMin);
                    Console.ReadKey();

                    leaveProgram();

                } catch (Exception ex)
                {
                }

            }
        } public static void leaveProgram()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Enter 1 to leave or 2 to repeat");

            string leave = Console.ReadLine();

            if (leave == "1")
            {
                quit = true;
            }
            else 
            {

            }
            
        } public static void checkTime1()
        {
            //asks for the first time
            Console.WriteLine("Time Calculator\n");

            Console.WriteLine("Enter the starting Hour");
            string inputhour = Console.ReadLine();
             hour = Int32.Parse(inputhour);

            Console.WriteLine("Enter the starting Minutes");
            string inputminutes = Console.ReadLine();
             minutes = Int32.Parse(inputminutes);

            
            
        }
       public static void checkTime2()
        {
            //asks for the second time
            Console.WriteLine("Enter the End Hour");
            string inputhour2 = Console.ReadLine();
             hour2 = Int32.Parse(inputhour2);

            Console.WriteLine("Enter the End Mintues");
            string inputminutes2 = Console.ReadLine();
             minutes2 = Int32.Parse(inputminutes2);

            Console.Clear();

            Console.WriteLine("Calculating : Time from {0}:{1} to {2}:{3}", hour, minutes, hour2, minutes2);
            ShowSimplePercentage();
            Console.WriteLine("Press any Key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void calculation()
        {
            if (hour2 > hour)
            {
                calculationHours = hour2 - hour; 
            }
            else if (hour > hour2)
            {
                calculationHours = hour2 - hour;
                calculationHours = calculationHours + 24;
            }





            if ( minutes2 > minutes)
            {
                calculationMin = minutes2 - minutes;
            }
            else if (minutes > minutes2)
            {
                calculationHours--;

                calculationMin = minutes2 - minutes;
                calculationMin = 60 + calculationMin;

                
            }
        }
        static void ShowSimplePercentage()
        {
            for (int i = 0; i <= 100; i+= 4)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }

            Console.Write("\rDone! ");
        }



    }
}
