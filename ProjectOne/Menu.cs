using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using static ProjectOne.Program;

namespace ProjectOne
{
    internal class Menu
    {


        
        /////////////// Add /////////////// 
        public static void PhoneAdd()
        {

            Console.WriteLine("Phone Added");

            Console.Write("Lütfen isim giriniz:");
            string userName = Convert.ToString(Console.ReadLine());

            Console.Write("Lütfen soyisim giriniz:");
            string userSurname = Convert.ToString(Console.ReadLine());

            Console.Write("Lütfen telefon no giriniz:");
            int phone = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Belirtilen kişi ve numara başarıyla rehbere eklendi.");
        }



        /////////////// Search /////////////// 
        public static void PhoneSearch()
        {
            throw new NotImplementedException();
        }



        /////////////// List /////////////// 
        public static void PhoneListed()
        {
            throw new NotImplementedException();
        }



        /////////////// Update /////////////// 
        public static void PhoneUpdate()
        {
            throw new NotImplementedException();
        }


        /////////////// Delete /////////////// 
        public static void PhoneDelete()
        {
            throw new NotImplementedException();
        }
    }
}
