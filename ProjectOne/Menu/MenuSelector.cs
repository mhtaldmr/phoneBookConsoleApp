using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Menu
{
    internal class MenuSelector
    {
        public static void Selector(int input, List<Person> phonebook)
        {

            switch (input)
            {
                case 1:
                    Menu.Actions.AddPhone.Add(phonebook);
                    break;
                case 2:
                    Menu.Actions.DeletePhone.Delete(phonebook);
                    break;
                case 3:
                    Menu.Actions.UpdatePhone.Update(phonebook);
                    break;
                case 4:
                    Menu.Actions.ListPhone.Listed(phonebook);
                    break;
                case 5:
                    Menu.Actions.SearchPhone.Search(phonebook);
                    break;
                case 6:
                    Console.WriteLine("\nÇıkış yapıldı..");
                    break;
                default:
                    Console.WriteLine("\nYanlış Giriş!\n");
                    break;

            }
        }
    }
}
