using System;
using System.Collections.Generic;

namespace ProjectOne
{
    internal partial class Program
    {

        public class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; } 
            public int PhoneNumber { get; set; }

            //public List<Person> MyList { get; set; }

            public Person(string name, string surname, int phone)
            {
                Name = name;
                Surname = surname;
                PhoneNumber = phone;
            }
        }
    }
}
