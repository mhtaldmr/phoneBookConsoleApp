using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Entity
{
    internal class DefaultList
    {
        public static void DefaultPhoneBook(List<Person> phonebook)
        {
            phonebook.Add(new Person { Name = "Daniel", Surname = "Riccado", PhoneNumber = "123 - 221" });
            phonebook.Add(new Person { Name = "Max", Surname = "Verstapen", PhoneNumber = "0369 - 638"});
            phonebook.Add(new Person { Name = "Charles", Surname = "Leclerc", PhoneNumber = "0441 - 675" });
            phonebook.Add(new Person { Name = "Carlos", Surname = "Sainz", PhoneNumber = "0963 - 275" });
            phonebook.Add(new Person { Name = "Lewis", Surname = "Hamilton", PhoneNumber = "0799 - 446" });
        }
    }
}
