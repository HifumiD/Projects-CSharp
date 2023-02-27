using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Bosses
{
    internal class Trainees : Employee
    {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        public Trainees() { }

        public Trainees(int workingHours, int schoolHours,string name, string firstname,int salary):base(name,firstname,salary) 
        { 
            WorkingHours= workingHours;
            SchoolHours= schoolHours;

        } 

        public override void Work()
        {
            Console.WriteLine("Trainee is working");
        }

        public void Learn()
        {
            Console.WriteLine("Trainee am learning");
        }



    }
}
