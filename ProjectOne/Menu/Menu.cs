using System;
using System.Collections.Generic;


namespace ProjectOne
{
    public static class Menu
    {

      
        
        /////////////// Add /////////////// 
        public static void PhoneAdd(List<Person> listOfPeople)
        {
            Person newPerson = new();

            Console.Write("Lütfen isim giriniz:");
            newPerson.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Lütfen soyisim giriniz:");
            newPerson.Surname = Convert.ToString(Console.ReadLine());

            Console.Write("Lütfen telefon no giriniz:");
            newPerson.PhoneNumber = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Belirtilen kişi ve numara başarıyla rehbere eklendi.\n");

            
            listOfPeople.Add(newPerson);
        }



        /////////////// Search /////////////// 
        public static void PhoneSearch()
        {
            Console.WriteLine("Searched");
        }



        /////////////// List /////////////// 
        public static void PhoneListed()
        {
            Console.WriteLine("Listed");
        }



        /////////////// Update /////////////// 
        public static void PhoneUpdate()
        {
            Console.WriteLine("Updated");
        }


        /////////////// Delete /////////////// 
        public static void PhoneDelete()
        {
            Console.WriteLine("Deleted");
        }
    }
}
