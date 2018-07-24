using System;

namespace _7_24_SkillsTest
{
    
    public class Person
    {
      public  int Id;
      public string FirstName;
    public String LastName;
      public  DateTime DOB;

        public Person(int id, string firstName, string lastName, DateTime dob)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DOB = dob;
        }
    }
}
