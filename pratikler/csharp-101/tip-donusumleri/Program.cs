using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //bilincsiz donusum (implicit)
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d : " + d);

            long h = d;
            Console.WriteLine("h : " + h);

            float i = h;
            Console.WriteLine("i : " + i);

            string e = "Batuhan";
            char f = 'B';
            object g = e + f + d;
            Console.WriteLine("g : " + g);


            //bilincli donusum  (explicit)
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y : " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t : " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v : " + v);


            // .ToString()  
            int s = 6;
            string s2 = s.ToString();
            Console.WriteLine("s2 : " + s2);

            string pi = 3.14f.ToString();
            Console.WriteLine("pi : " + pi);


            // System.Convert
            string str1 = "10", str2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(str1);
            sayi2 = Convert.ToInt32(str2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam: " + toplam);


            // Parse
            
            Console.WriteLine("-----------Parse---------");
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1 : " + rakam1);
            Console.WriteLine("double1 : " + double1);
        } 
    }
}