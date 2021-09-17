using System;

namespace metotlar
{
    class Program
    {
         public static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a + b));

        }
        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri1)
        {
            Console.WriteLine(veri1);
        }
        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}