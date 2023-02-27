using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Bosses
{
    internal class Boss : Employee
    {
        protected string CompanyCar { get; set; }

        public Boss() { }
        
        public Boss(string companyCar, string name, string firstname, int salary ) :base(name,firstname,salary) 
        {
            CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("I am leading");
        }

        public override void Work()
        {
            Console.WriteLine("Boss is working");
        }









    }
}
