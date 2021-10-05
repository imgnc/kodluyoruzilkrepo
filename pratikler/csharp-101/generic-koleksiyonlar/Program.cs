using System;
using System.Collections.Generic;

namespace generic_koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numLs=new List<int>();

            numLs.Add(63);
            numLs.Add(1);
            numLs.Add(24);
            numLs.Add(51);
            numLs.Add(32);
            numLs.Add(12);

            List<string> colorLs=new List<string>();
            colorLs.Add("kırmızı");
            colorLs.Add("mavi");
            colorLs.Add("yeşil");
            colorLs.Add("sarı");
            colorLs.Add("siyah");
            
            Console.WriteLine(colorLs.Count);
            Console.WriteLine(numLs.Count);

            foreach (var num in numLs)
                Console.WriteLine(num);

             foreach (var clr in colorLs)
                Console.WriteLine(clr);

            numLs.ForEach(x=>Console.WriteLine(x));
            numLs.ForEach(x=>Console.WriteLine(x));

            numLs.Remove(4);
            colorLs.Remove("siyah");

            numLs.RemoveAt(0);
            colorLs.RemoveAt(1);




            if (numLs.Contains(12))
            {
                Console.WriteLine("***** bulunamadı *****");
            }


            Console.WriteLine(colorLs.BinarySearch("sarı"));


            string[] havyanDizi={"at","köpek","kuş"};

            List<string> havyanLS=new List<string>(havyanDizi);

            havyanLS.Clear();



            List<Kullanici> kullaniciLs=new List<Kullanici>();
            Kullanici kullanici=new Kullanici();
            kullanici.Ad="A";
            kullanici.Soyad="3";
            kullanici.Yas=22;
            kullaniciLs.Add(kullanici);

            Kullanici kullanici1=new Kullanici();
            kullanici1.Ad="Deneme";
            kullanici1.Soyad="Test";
            kullanici1.Yas=25;

            kullaniciLs.Add(kullanici1);


            List<Kullanici> kullaniciLs2=new List<Kullanici>();
            kullaniciLs2.Add(new Kullanici(){Ad="AA",Soyad="BB",Yas=35});


            foreach (var item in kullaniciLs2) 
                Console.WriteLine("Ad : "+item.Ad); 

            kullaniciLs2.Clear();

            Console.ReadLine();
        }

        public class Kullanici{
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int Yas { get; set; }
        }
    } 
}