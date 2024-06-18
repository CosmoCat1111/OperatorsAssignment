using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "Steve", "Jobs"); //creating employees
            Employee emp2 = new Employee(2, "Fred", "Penner");

            if (emp1 == emp2)
            {
                Console.WriteLine("Both Employees are the same!");
            }
            else
            {
                Console.WriteLine("Emp1 and Emp2 are not the same!");
            }



            Employee emp3 = new Employee(1, "Barbara", "Walters"); //create new emp to compare to emp1 
            
                if (emp1 == emp3) // comparing to see if same
            {
                Console.WriteLine("Emp1 and Emp3 are the same!");
            }
                else // comparing to see if not 
            {
                Console.WriteLine("Emp1 and Emp3 are not the same!");
            }
            Console.ReadLine();
        }
    }
}
