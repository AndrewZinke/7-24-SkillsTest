using System;

namespace _7_24_SkillsTest
{
    
    public class Employee : Person
    {

      public  string Department;
      public  int EmployeeId;
       public DateTime DOJ;

        public Employee(string firstName, string lastName, string department, int employeeId, DateTime dOJ, DateTime dob)
        : base(employeeId, firstName, lastName,dob)
        {
               Department = department;
               EmployeeId = employeeId;
               DOJ = dOJ;
        }


        }
    } // end of namespace

