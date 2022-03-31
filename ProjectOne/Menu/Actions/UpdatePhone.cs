using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Menu.Actions
{
    internal class UpdatePhone
    {
        public static void Update(List<Person> listOfPeople)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("Güncellenecek kişinin ismini seçiniz!");
            var nameToUpdate = Convert.ToString(Console.ReadLine().Trim());

            var personToUpdate = listOfPeople.Where(p => p.Name == nameToUpdate).SingleOrDefault();

            Console.WriteLine("Güncellemek istediğiniz bilgileri giriniz.");
            Console.Write("Lütfen isim giriniz:");
            personToUpdate.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Lütfen soyisim giriniz:");
            personToUpdate.Surname = Convert.ToString(Console.ReadLine());

            Console.Write("Lütfen telefon no giriniz:");
            personToUpdate.PhoneNumber = Convert.ToInt32(Console.ReadLine().Trim());


            Console.WriteLine(personToUpdate.Name + " isimli kişi güncellenmiştir.\n");

        }
    }
}
