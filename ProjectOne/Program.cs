using System;
using System.Collections.Generic;

namespace ProjectOne
{
    class Program
    {
        
        public static List<Person> Phonebook = new();
        
        public static void Main()
        {

            int input = 0;
            while (input != 6)
            {

                MenuList.MenuOpening();
                
                input = Convert.ToInt32(Console.ReadLine().Trim());
                MenuList.Selector(input, Phonebook);

                foreach (Person person in Phonebook)
                {
                    Console.WriteLine(person.Name);
                }
            }
        }
    }
}
