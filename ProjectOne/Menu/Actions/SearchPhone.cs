using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Menu.Actions
{
    internal class SearchPhone
    {
        public static void Search(List<Person> listOfPeople)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("Aranacak kişinin ismini seçiniz!");


            var nameToSearch = Convert.ToString(Console.ReadLine().Trim());
            var searchedPerson= listOfPeople.Where(p => p.Name == nameToSearch).SingleOrDefault();
               
            Console.WriteLine("İsim : " + searchedPerson.Name);
            Console.WriteLine("Soyisim : " + searchedPerson.Surname);
            Console.WriteLine("Telefon : " + searchedPerson.PhoneNumber);
        }
    }
}
