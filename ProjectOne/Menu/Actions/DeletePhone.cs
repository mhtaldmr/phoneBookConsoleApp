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
            Console.Write("Silinecek kişinin ismini seçiniz: ");
            var nameToDelete = Convert.ToString(Console.ReadLine().Trim());

            Console.Write("Silinecek kişinin soy ismini seçiniz: ");
            var surnameToDelete = Convert.ToString(Console.ReadLine().Trim());

            var personToDelete = listOfPeople.Where(p => p.Name == nameToDelete && p.Surname == surnameToDelete).FirstOrDefault();
            
            if (personToDelete != null)
            {
                Console.WriteLine(personToDelete.Name + " " + personToDelete.Surname + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                var validation = Convert.ToString(Console.ReadLine().Trim());
                if(validation == "y")
                {
                    listOfPeople.Remove(personToDelete);
                    Console.WriteLine(personToDelete.Name + " isimli kişi silinmiştir.\n");
                }else if(validation == "n")
                {
                    Menu.Actions.DeletePhone.Delete(listOfPeople);
                }
            }
            else
            {
                Console.WriteLine("Belirtilen isimli kişi bulunamamamıştır.\n");
                Console.WriteLine("Silmeyi Sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için : (2)");
                var lastSelection = Convert.ToInt32(Console.ReadLine().Trim());
                if(lastSelection == 1)
                {
                    Console.WriteLine("Silme Sonlandırılmıştır");
                }else if(lastSelection == 2)
                {
                    Menu.Actions.DeletePhone.Delete(listOfPeople);
                }
            }


        }
    }
}
