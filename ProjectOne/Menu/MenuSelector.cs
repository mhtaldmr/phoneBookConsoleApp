using ProjectOne.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Menu
{
    internal static class MenuSelector
    {
        public static void Selector(int input, List<Person> phonebook)
        {
            OperationType selectedOperation = (OperationType)input;

            switch (selectedOperation)
            {
                case OperationType.Add:
                    Menu.Actions.AddPhone.Add(phonebook);
                    break;
                case OperationType.Delete:
                    Menu.Actions.DeletePhone.Delete(phonebook);
                    break;
                case OperationType.Update:
                    Menu.Actions.UpdatePhone.Update(phonebook);
                    break;
                case OperationType.List:
                    Menu.Actions.ListPhone.Listed(phonebook);
                    break;
                case OperationType.Search:
                    Menu.Actions.SearchPhone.Search(phonebook);
                    break;
                case OperationType.Exit:
                    Console.WriteLine("\nÇıkış yapıldı..");
                    break;
                default:
                    Console.WriteLine("\nYanlış Giriş!\n");
                    break;

            }
        }
    }
}
