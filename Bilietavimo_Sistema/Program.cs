﻿using System;
using System.Collections.Generic;

namespace Bilietavimo_Sistema
{
    class Program
    {
        static void Main(string[] args)
        {

            MainMenu();

            
            //Antras(pirktiParduoti);
            
            //int antrasPasirinkimas = BilietoTipas();
            //Trecias(antrasPasirinkimas);
            
        }
        public static int GautiBilietoTipa()
        {

        }
        public static void Trecias(int antrasPasirinkimas)
        {
             //num = BilietoTipas();

            switch (antrasPasirinkimas)
            {
                case 1:
                    BilietuKiekis();
                    break;
                case 2:
                    BilietuKiekis();
                    break;
                case 3:
                    BilietuKiekis();
                    break;
            }
            //BilietuKiekis();
        }
        public static void Antras(int pirktiParduoti)
        {
            switch (pirktiParduoti)
            {
                case 1:
                    BilietoTipas();                    
                    break;
                case 2:
                    BilietoTipas();
                    break;
                case 3:
                    BilietoTipas();
                    break;
            }
             
        }
        public static void KurtiBilietus10()
        {

        }
        public static void SarasoKurimas()
        {
            List<int> SukurtiBilietai10 = new List<int>();
            List<int> SukurtiBilietai20 = new List<int>();
            List<int> SukurtiBilietai30 = new List<int>();
        }
        public static int BilietuKiekis()
        {
            Console.WriteLine("Iveskite kieki: ");
            int kiekis = int.Parse(Console.ReadLine());
            return kiekis;
        }
        public static int BilietoTipas()
        {
            Console.WriteLine("Pasirinkite bilieto tipa: [1] - 10 EUR, [2] - 20 EUR, [3] - 3 EUR");
            int bilietoTipas = int.Parse(Console.ReadLine());
            return bilietoTipas;
        }
        //public static int Meniu()
        //{
        //    Console.WriteLine("[1] PARDUOTI bilietus, [2] KURTI bilietus");
        //    int pirmasPasirinkimas = int.Parse(Console.ReadLine());
        //    return pirmasPasirinkimas;
        //}

        public static int MainMenu()
        {
            Console.WriteLine("[1] PARDUOTI bilietus, [2] KURTI bilietus");
            int pirktiParduoti = int.Parse(Console.ReadLine());
            return pirktiParduoti;
        }
    }
}
