using System;

namespace metot_overloading
{
    class Program
    {
static void Main(string[] args)
        {
            // out parametreler
            string sayi = "999";
            int outSayi;

            bool sonuc = int.TryParse(sayi, out outSayi);

            if (sonuc)
            {
                Console.WriteLine("Başarılı.");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız.");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);


            // metot overloading
            int ifade = 999;
            instance.ekranaYazdir(Convert.ToString(ifade));
            instance.ekranaYazdir(ifade);
            instance.ekranaYazdir("IM ", "GEN");
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void ekranaYazdir(string veri1)
        {
            Console.WriteLine(veri1);
        }

        public void ekranaYazdir(int veri1)
        {
            Console.WriteLine(veri1);
        }

        public void ekranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}