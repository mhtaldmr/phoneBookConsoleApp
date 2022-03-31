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

                MenuList.List();
                input = Convert.ToInt32(Console.ReadLine().Trim());
                Menu.MenuSelector.Selector(input, Phonebook);

            }
        }
    }
}
