using System;

namespace operatorler
{
    class Program
    {
        public static void Main(string[] args)
        {  
            //Soru1();
            //Soru2();
            //Soru3();
            Soru4();
            Console.ReadLine();
        }

/*
[*] Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
[*] Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
[*] Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
*/
        static void Soru1()
        { 
            int sayi = PozitifSayiKontrolu("Pozitif sayı giriniz: ");
            int[] girilenSayilar= new int [sayi];
            for(int i=0;i<sayi; i++)
               girilenSayilar[i]= PozitifSayiKontrolu($"{i+1}. pozitif sayıyı giriniz: ");

            System.Console.WriteLine("---Girilen Çift Sayılar---");
            foreach (var girilenSayi in girilenSayilar)
            {
                if(girilenSayi%2==0)
                   System.Console.WriteLine(girilenSayi);
            }
        }

        static int PozitifSayiKontrolu(string mesaj)
        {
            string sayiStr= "";
            int sayi;
            while(!int.TryParse(sayiStr,out sayi) || sayi<1)
            {
                 Console.Write(mesaj);
                 sayiStr = Console.ReadLine(); 
            } 
            return sayi;
        }

        /*
        [*] Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
        [*] Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        [*] Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        */

       static void Soru2()
       {
            int sayi1 = PozitifSayiKontrolu("1. Pozitif sayıyı giriniz (n): ");
            int sayi2 = PozitifSayiKontrolu("2. Pozitif sayıyı giriniz (m): "); 
            
            System.Console.WriteLine("------------");
            int[] girilenSayilar= new int [sayi1];
            for(int i=0;i<sayi1; i++)
               girilenSayilar[i]= PozitifSayiKontrolu($"{i+1}. pozitif sayıyı giriniz: ");

            System.Console.WriteLine("------------");
            System.Console.WriteLine($"Girilen {sayi1} adet sayı, {sayi2} sayısına tam bölünebilen sayılar;");
            for(int i=0;i<sayi1; i++)
            { 
                if(girilenSayilar[i]%sayi2==0)
                   System.Console.WriteLine(girilenSayilar[i]);
            }

       }

/*
[*] Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
[*] Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
[*] Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
*/
       static void Soru3()
       {
            int sayi = PozitifSayiKontrolu("Pozitif sayı giriniz: ");
            string[] girilenKelimeler= new string [sayi];
            for(int i=0;i<sayi; i++){        
                 Console.Write($"{i+1}.kelimeyi giriniz: ");        
                 girilenKelimeler[i]= Console.ReadLine();
            }

            //1.Yöntem
            Array.Reverse(girilenKelimeler); 
            foreach(string kelime in girilenKelimeler)
                System.Console.WriteLine(kelime);

            //2.Yöntem
            // for(int i=sayi-1;i>=0;i--)
            //     System.Console.WriteLine(girilenKelimeler[i]);
       }

       /*
       [] Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
       [] Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
       */
       static void Soru4()
       {
           Console.Write("Cümle Giriniz: ");
           string cumle= Console.ReadLine(); 
           string[] kelimeler = cumle.Split(' ');
           int kelimeSayisi= kelimeler.Length;
           System.Console.WriteLine($"Kelime Sayısı : {kelimeSayisi}");
           System.Console.WriteLine($"Harf Sayısı : {cumle.Length}");
       }
    }
     
}
