using System;
using System.Collections.Generic;

namespace ProjectOne
{
    public class MenuList
    {
        public static void MenuOpening()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");

        }

        public static void Selector(int input, List<Person> phonebook)
        {
            
            switch (input)
            {
                case 1:
                    Menu.PhoneAdd(phonebook);
                    break;
                case 2:
                    Menu.PhoneDelete();
                    break;
                case 3:
                    Menu.PhoneUpdate();
                    break;
                case 4:
                    Menu.PhoneListed();
                    break;
                case 5:
                    Menu.PhoneSearch();
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
