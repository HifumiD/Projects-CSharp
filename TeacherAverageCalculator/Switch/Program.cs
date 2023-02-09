using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Serialization;

namespace Switch
{
    internal class Program

    {
        static void Main(string[] args)
        {
            int students = 0;
            double sum = 0;
            string score = "";
            bool quit = false;
            
                do
                {
                try
                {
                    Console.WriteLine("Enter a value from 0 to 20 for each one of your students");

                    score = Console.ReadLine();
                    int choice = int.Parse(score);

                    if (choice >= 0 && choice <= 20)
                    {
                        Console.Clear();
                        students++;
                        Console.WriteLine("You have entered {0}", choice);
                        sum = choice + sum;
                        Console.WriteLine("Total ammount is {0}", sum);
                    }
                    else if (choice == -1)
                    {
                        if (students == 0)
                        {

                            Console.WriteLine("You have no data");
                        }
                        else
                        {
                            quit = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your number was to big");

                    }
                } catch (Exception) 
                {
                    Console.Clear();
                    Console.WriteLine("You entered a wrong value, please enter a number between 0 and 20");
                    Console.WriteLine("------------------------------------------------------------------");
                }
                

            } while (quit==false);
            Console.Clear ();
            double final = sum / students;
            Console.WriteLine("The total ammount of grades is {0} with {1} students", sum, students);
            Console.WriteLine("The average grade of your students is {0}", final);
            


        }
    }
}


    

