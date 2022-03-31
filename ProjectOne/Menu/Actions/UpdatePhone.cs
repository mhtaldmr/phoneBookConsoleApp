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
            Console.Write("Güncellenecek kişinin ismini yazınız: ");
            var nameToUpdate = Convert.ToString(Console.ReadLine().Trim());

            Console.Write("Güncellenecek kişinin soy ismini yazınız: ");
            var surnameToUpdate = Convert.ToString(Console.ReadLine().Trim());

            var personToUpdate = listOfPeople.Where(p => p.Name == nameToUpdate && p.Surname == surnameToUpdate).FirstOrDefault();


            if (personToUpdate != null)
            {
                Console.WriteLine("Güncellemek istediğiniz bilgileri giriniz.");
                Console.Write("Lütfen isim giriniz:");
                personToUpdate.Name = Convert.ToString(Console.ReadLine());

                Console.Write("Lütfen soyisim giriniz:");
                personToUpdate.Surname = Convert.ToString(Console.ReadLine());

                Console.Write("Lütfen telefon no giriniz:");
                personToUpdate.PhoneNumber = Convert.ToString(Console.ReadLine().Trim());

                Console.WriteLine(personToUpdate.Name + " isimli kişi güncellenmiştir.\n");
            }
            else
            {
                Console.WriteLine("Belirtilen isimli kişi bulunamamamıştır.\n");
                Console.WriteLine("Güncellemeyi Sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için : (2)");
                var lastSelection = Convert.ToInt32(Console.ReadLine().Trim());
                if (lastSelection == 1)
                {
                    Console.WriteLine("Güncellendirme Sonlandırılmıştır");
                }
                else if (lastSelection == 2)
                {
                    Menu.Actions.UpdatePhone.Update(listOfPeople);
                }
            }







        }
    }
}
