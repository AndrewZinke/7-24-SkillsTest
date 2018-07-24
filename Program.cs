using System;

namespace _7_24_SkillsTest
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];

            DateTime dob1 = new DateTime(1,1,1);
            DateTime dob2 = new DateTime(2,2,2);
            DateTime dob3 = new DateTime(3,3,3);
            employees[0] = new Employee("Harry", "Potter", "Sales", 1, dob1,dob2);
            employees[1] = new Employee("Ron", "Weasly", "IT", 2, dob2,dob3);
            employees[2] = new Employee("Albus", "Dumbledore", "Engineer", 3, dob3,dob1);

            Console.WriteLine("Initial List of Employees:");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{employees[i].FirstName}, {employees[i].LastName}, {employees[i].Id}, {employees[i].Department}, {employees[i].DOJ}, {employees[i].DOB}");     
            }
            Console.WriteLine("");
            Customer[] customers = new Customer[3];

            customers[0] = new Customer("Hermoine", "Granger", 10, "89 Park Way", "Fargo","ND", dob3 );
            customers[1] = new Customer("Joe", "Jimmy", 11, "101 Forest Way", "Bismark","ND", dob1 );
            customers[2] = new Customer("Bill", "Billy", 12, "321 Broadway", "Bemidji","MN" , dob2);

            Console.WriteLine("Initial List of Customers:");
            for( int i =0; i < 3; i++)
            {
            Console.WriteLine($"{customers[i].FirstName}, {customers[i].LastName}, {customers[i].Id}, {customers[i].Address}, {customers[i].City}, {customers[i].State}, {customers[i].DOB}");
            }
            Console.WriteLine("");
        

            for(int i = 0; i < employees.Length -1;i++){
                for(int j = 1; j < employees.Length; j++){
                    if(employees[i].FirstName.CompareTo(employees[j].FirstName)  > 0)
                    {
                        Employee temp = employees[i];
                        employees[i] = employees[j];
                        employees[j] = temp;
                    }
                }
            }

            Console.WriteLine("After Sorting Employee Array:");
            for(int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"{employees[i].FirstName}, {employees[i].LastName}, {employees[i].Id}, {employees[i].Department}, {employees[i].DOJ}, {employees[i].DOB}");     
            }
            Console.WriteLine("");

            //to do:
            //sort Arrays FirstName
            //push code to git

            for(int i = 0; i < customers.Length -1;i++){
                for(int j = 1; j < customers.Length; j++){
                    if(customers[i].FirstName.CompareTo(customers[j].FirstName)  > 0)
                    {
                        Customer temp = customers[i];
                        customers[i] = customers[j];
                        customers[j] = temp;
                    }
                }
            }

            Console.WriteLine("After Sorting Customer Array:");
            for(int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine($"{customers[i].FirstName}, {customers[i].LastName}, {customers[i].Id}, {customers[i].Address}, {customers[i].City}, {customers[i].State}, {customers[i].DOB}");     
            }
            Console.WriteLine("");

        }
    }
}
