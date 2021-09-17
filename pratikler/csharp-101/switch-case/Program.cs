using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int ay = DateTime.Now.Month; 
            switch (ay)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız.");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız.");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız.");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girişi!");
                    break; 
            }

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış aylarındasınız.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar aylarındasınız.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz aylarındasınız.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar aylarındasınız.");
                    break;
                default:
                    break;
            }
        }
    }
}