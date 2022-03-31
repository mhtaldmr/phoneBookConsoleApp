using System;

namespace ProjectOne
{
    internal class MenuList
    {
        public static void MenuOpening()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) \n******************************************* \n (1) Yeni Numara Kaydetmek \n (2) Varolan Numarayı Silmek \n (3) Varolan Numarayı Güncelleme \n (4) Rehberi Listelemek \n (5) Rehberde Arama Yapmak﻿ ");
        }

        public static void Selector()
        {
            int input = Convert.ToInt32(Console.ReadLine().Trim());

            switch (input)
            {
                case 1:
                    Menu.PhoneAdd();
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

            }


        }

    }
}
