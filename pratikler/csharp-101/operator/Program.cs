using System;

namespace operatorler
{
    class Program
    {
        public static void Main(string[] args)
        { 
            //değişken tanımlama, atama ve islemli atama
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y = 1;
            Console.WriteLine(y);
            x = 2;
            Console.WriteLine(x);


            // mantiksal operatorler
            bool basariliMi = true;
            bool tamamlamlandiMi = false;

            if (basariliMi && tamamlamlandiMi)
            {
                Console.WriteLine("Mükemmel!");
            }

            if (basariliMi || tamamlamlandiMi)
            {
                Console.WriteLine("Harika!");
            }

            if (basariliMi && !tamamlamlandiMi)
            {
                Console.WriteLine("İyi!");
            }


            // iliskisel operatorler
            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);



            // aritmetik operatorler
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;

            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);
        }
    }
     
}
