using System;

namespace Employee_Bosses
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Boss boss= new Boss("Ferrary", "Norris", "Chuck", 900);

           Trainees trainee = new Trainees();

            Employee employee = new Employee("Mike", "Bingus", 3400);

            employee.Work();
            boss.Lead();
        }
    }
}
