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
            Console.WriteLine("Aranacak istediğiniz tipi seçiniz!");
            Console.WriteLine("Aranacak istediğiniz tipi seçiniz!");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            var searchType = Convert.ToInt32(Console.ReadLine().Trim());

            if(searchType == 1)
            {
                Console.Write("Aramak istediğiniz ismi veya soyismi giriniz: ");
                var nameToSearch = Convert.ToString(Console.ReadLine().Trim());
                Console.WriteLine("--");

                var searchedPeoplebyName = listOfPeople.Where(p => p.Name == nameToSearch || p.Surname == nameToSearch);

                if (searchedPeoplebyName.Count() == 0)
                {
                    Console.WriteLine("Uygun kriterlerde kişi bulunamadı.");
                    Console.WriteLine("--");
                }


                foreach (var p in searchedPeoplebyName)
                {
                    Console.WriteLine("İsim : " + p.Name);
                    Console.WriteLine("Soyisim : " + p.Surname);
                    Console.WriteLine("Telefon : " + p.PhoneNumber);
                    Console.WriteLine("--");
                }

                
            }
            else if(searchType == 2)
            {
                Console.Write("Aramak istediğiniz telefonu giriniz: ");
                var phoneToSearch = Convert.ToString(Console.ReadLine().Trim());
                Console.WriteLine("--");

                var searchedPeoplebyPhone = listOfPeople.Where(p => p.PhoneNumber == phoneToSearch);

                if(searchedPeoplebyPhone.Count() == 0)
                {
                    Console.WriteLine("Uygun kriterlerde kişi bulunamadı.");
                    Console.WriteLine("--");
                }

                foreach (var p in searchedPeoplebyPhone)
                {
                    Console.WriteLine("İsim : " + p.Name);
                    Console.WriteLine("Soyisim : " + p.Surname);
                    Console.WriteLine("Telefon : " + p.PhoneNumber);
                    Console.WriteLine("--");
                }

            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız. Yeniden Deneyiniz.");
                Menu.Actions.SearchPhone.Search(listOfPeople);
            }



        }
    }
}
