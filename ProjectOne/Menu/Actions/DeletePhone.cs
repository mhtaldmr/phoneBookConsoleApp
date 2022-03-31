using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Menu.Actions
{
    internal class DeletePhone
    {
        public static void Delete(List<Person> listOfPeople)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("Silinecek kişinin ismini seçiniz!");
            var nameToDelete = Convert.ToString(Console.ReadLine().Trim());

            var personToDelete = listOfPeople.Where(p => p.Name == nameToDelete).SingleOrDefault();
            listOfPeople.Remove(personToDelete);
            Console.WriteLine(personToDelete.Name + " isimli kişi silinmiştir.\n");


        }
    }
}
