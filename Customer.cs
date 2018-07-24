using System;

namespace _7_24_SkillsTest
{
    
    public class Customer : Person
    {
      public  String Address;
      public  String City;
       public String State;

        public Customer(string firstName, string lastName, int id, string address, string city, string state, DateTime dob) 
        : base( id, firstName, lastName, dob)
        {
           Address = address;
           City = city;
           State = state;
        }
    }
}
