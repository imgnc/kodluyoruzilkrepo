using System;

namespace degisken
{
    class Program
    {
        public static void Main(string[] args)
        { 
            int sayi = 2;
            string metin = "2";
            char karakter = 'A';
            Console.WriteLine(karakter); 
            Console.WriteLine(Convert.ToInt32(karakter)); 

            int toplam = sayi + Convert.ToInt32(metin);
            Console.WriteLine(toplam); 

            DateTime tarih= DateTime.Now;
            Console.WriteLine(tarih.ToString("yyyy-MM-dd")); 

        }
    }
     
}
