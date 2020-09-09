using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicimselOdev
{
    class Program
    {
        //Gerekli degiskenleri tanimliyoruz.
        public static int sayac = 0;
        public static int ifadeUzunlugu;
        public static String ifade;
        public static bool deger = false;
        static void Main(string[] args)
        {
            
            Console.Write("Reguler Ifadeyi giriniz:");
            ifade = Console.ReadLine(); // Kullanicidan Reguler ifadeyi istiyoruz.
            ifadeUzunlugu = ifade.Length; // Reguler ifadenin uzunlugunu aliyoruz.
            Akabul(); // A duruma gidiyoruz.
            Console.ReadKey();
        }
        static bool sonaGeldikMi() // Reguler ifadeyi okurken son karaktere gelip gelmedigimizi kontrol ediyoruz.
        {
            if (sayac == ifadeUzunlugu)
            {
                deger = true;
            }
            else
            {
                deger = false;
            }
            return deger;
        }
        static void Akabul()
        {
            if (sonaGeldikMi() == true) // Eger son karaktere geldigimizde kabul durumunun icindeysek ifade taniniyor yazdiriyoruz.
            {
                Console.WriteLine("Girilen Reguler Ifade TANINIYOR..");
            }
            else // Eger son karakterde degilsek
            {
                if (ifade[sayac] == 'a') // Eger okunan karakter a ise B durumuna gidiyoruz ve sayaci bir arttirarak okuyacagimiz karakteri bir sonraki karakter olarak belirliyoruz.
                {
                    sayac++;
                    B();
                }
                else if(ifade[sayac] == 'b') // Eger okunan karakter b ise C durumuna gidiyoruz ve sayaci bir arttirarak okuyacagimiz karakteri bir sonraki karakter olarak belirliyoruz.
                {
                    sayac++;
                    Ckabul();
                }
                else // Eger a ya da b den baska bir karakter girildiyse ifade taninmiyor yazdiriyoruz.
                {
                    Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
                }
            }   
        }
        static void B()
        {
            if (sonaGeldikMi() == true) // Eger son karaktere geldigimizde kabul durumunun icinde degilsek ifade taninmiyor yazdiriyoruz.
            {
                Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
            }
            else
            {
                if (ifade[sayac] == 'a') // Eger okunan karakter a ise D durumuna gidiyoruz ve sayaci bir arttirarak okuyacagimiz karakteri bir sonraki karakter olarak belirliyoruz.
                {
                    sayac++;
                    Dkabul();
                }
                else if(ifade[sayac] == 'b') // Eger okunan karakter b ise E durumuna gidiyoruz ve sayaci bir arttirarak okuyacagimiz karakteri bir sonraki karakter olarak belirliyoruz.
                {
                    sayac++;
                    E();
                }
                else
                {
                    Console.WriteLine("Girilen Reguler Ifade TANINMIYOR.."); // Eger a ya da b den baska bir karakter girildiyse ifade taninmiyor yazdiriyoruz.
                }
            }
        }
        // Odevin geri kalan aciklamasi A ve B durumundaki gibidir.
        static void Ckabul()
        {
            if (sonaGeldikMi() == true)
            {
                Console.WriteLine("Girilen Reguler Ifade TANINIYOR..");
            }
            else
            {
                if (ifade[sayac] == 'a')
                {
                    sayac++;
                    F();
                }
                else if (ifade[sayac] == 'b')
                {
                    sayac++;
                    Ckabul();
                }
                else
                {
                    Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
                }
            }
        }
        static void Dkabul()
        {
            if (sonaGeldikMi() == true)
            {
                Console.WriteLine("Girilen Reguler Ifade TANINIYOR..");
            }
            else
            {
                if (ifade[sayac] == 'a')
                {
                    sayac++;
                    B();
                }
                else if (ifade[sayac] == 'b')
                {
                    sayac++;
                    Ckabul();
                }
                else
                {
                    Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
                }
            }
        }
        static void E()
        {
            if (sonaGeldikMi() == true)
            {
                Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
            }
            else
            {
                if (ifade[sayac] == 'a')
                {
                    sayac++;
                    Gkabul();
                }
                else if (ifade[sayac] == 'b')
                {
                    sayac++;
                    oluDurum();
                }
                else
                {
                    Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
                }
            }
        }
        static void F()
        {
            if (sonaGeldikMi() == true)
            {
                Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
            }
            else
            {
                if (ifade[sayac] == 'a')
                {
                    sayac++;
                    Dkabul();
                }
                else if (ifade[sayac] == 'b')
                {
                    sayac++;
                    Hkabul();
                }
                else
                {
                    Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
                }
            }
        }
        static void Gkabul()
        {
            if (sonaGeldikMi() == true)
            {
                Console.WriteLine("Girilen Reguler Ifade TANINIYOR..");
            }
            else
            {
                if (ifade[sayac] == 'a')
                {
                    sayac++;
                    I();
                }
                else if (ifade[sayac] == 'b')
                {
                    sayac++;
                    J();
                }
                else
                {
                    Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
                }
            }
        }
        static void Hkabul()
        {
            if (sonaGeldikMi() == true)
            {
                Console.WriteLine("Girilen Reguler Ifade TANINIYOR..");
            }
            else
            {
                if (ifade[sayac] == 'a')
                {
                    sayac++;
                    Gkabul();
                }
                else if (ifade[sayac] == 'b')
                {
                    sayac++;
                    J();
                }
                else
                {
                    Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
                }
            }
        }
        static void I()
        {
            if (sonaGeldikMi() == true)
            {
                Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
            }
            else
            {
                if (ifade[sayac] == 'a')
                {
                    sayac++;
                    oluDurum();
                }
                else if (ifade[sayac] == 'b')
                {
                    sayac++;
                    E();
                }
                else
                {
                    Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
                }
            }
        }
        static void J()
        {
            if (sonaGeldikMi() == true)
            {
                Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
            }
            else
            {
                if (ifade[sayac] == 'a')
                {
                    sayac++;
                    K();
                }
                else if (ifade[sayac] == 'b')
                {
                    sayac++;
                    oluDurum();
                }
                else
                {
                    Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
                }
            }
        }
        static void K()
        {
            if (sonaGeldikMi() == true)
            {
                Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
            }
            else
            {
                if (ifade[sayac] == 'a')
                {
                    sayac++;
                    oluDurum();
                }
                else if (ifade[sayac] == 'b')
                {
                    sayac++;
                    Lkabul();
                }
                else
                {
                    Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
                }
            }
        }
        static void Lkabul()
        {
            if (sonaGeldikMi() == true)
            {
                Console.WriteLine("Girilen Reguler Ifade TANINIYOR..");
            }
            else
            {
                if (ifade[sayac] == 'a')
                {
                    sayac++;
                    oluDurum();
                }
                else if (ifade[sayac] == 'b')
                {
                    sayac++;
                    J();
                }
                else
                {
                    Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
                }
            }
        }
        static void oluDurum()
        {
            Console.WriteLine("Girilen Reguler Ifade TANINMIYOR..");
        }
    }
}
