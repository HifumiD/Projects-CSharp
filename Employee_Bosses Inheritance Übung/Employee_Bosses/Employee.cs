using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Bosses
{
    internal class Employee
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }

        public Employee(string name, string firstname, int salary) 
        {
            Name = name;
            FirstName = firstname;
            Salary = salary;
        }

        public Employee() 
        {
            Name = "Default";
            FirstName = "Default";
            Salary = 0;
        }



        public virtual void Work()
        {
            Console.WriteLine("Employee is  working");
        }

        public  virtual void Pause()
        {
            Console.WriteLine("Employee is taking a break");
        }
    }



    


}
