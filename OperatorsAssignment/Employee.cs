using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        //properties of class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(int id, string firstName, string lastName) //constructor to initialize properties
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1?.Id == emp2?.Id; //check if equal
        }


        public static bool operator !=(Employee emp1, Employee emp2) //overload the opposite == and !=
            {
            return !(emp1 == emp2); //check if not equal
            }
    }
}
