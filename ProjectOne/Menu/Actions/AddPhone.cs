using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Menu.Actions
{
    static class AddPhone
    {
        /////////////// Add /////////////// 
        public static void Add(List<Person> listOfPeople)
        {
            Person newPerson = new();

            Console.Write("Lütfen isim giriniz:");
            newPerson.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Lütfen soyisim giriniz:");
            newPerson.Surname = Convert.ToString(Console.ReadLine());

            Console.Write("Lütfen telefon no giriniz:");
            newPerson.PhoneNumber = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("\nBelirtilen kişi ve numara başarıyla rehbere eklendi.\n");


            listOfPeople.Add(newPerson);
        }

    }
}
