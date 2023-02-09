using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
           do //for the loop of yes no
           {

                //asks for the name and age
                Console.Write("Insert your name: ");
            string name = Console.ReadLine(); 
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;

                //clears background and replies

                Console.Clear();
                Console.WriteLine("Hello {0} ", name);
                Console.WriteLine("Program works ");

                int age;
                Console.Write("Insert your age: ");
                age = Convert.ToInt32(Console.ReadLine());

                int sum = age * 12;

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                Console.WriteLine("You are {0} months old", sum);




                //asks for continuation



                Console.WriteLine("Do you want to continue (Y/N)? ");
            } while (Console.ReadKey().KeyChar != 'N');
        }
    }

}