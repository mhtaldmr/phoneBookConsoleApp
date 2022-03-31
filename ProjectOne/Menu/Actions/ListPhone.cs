using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Menu.Actions
{
    internal class ListPhone
    {
        public static void Listed(List<Person> listOfPeople)
        {
            foreach (Person person in listOfPeople)
            {
                Console.WriteLine("--");
                Console.WriteLine("İsim : " + person.Name);
                Console.WriteLine("Soyisim : " + person.Surname);
                Console.WriteLine("Telefon : " + person.PhoneNumber);
                Console.WriteLine("--");
            }
        }
    }
}
