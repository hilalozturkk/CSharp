using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;// bulunduğumuz ayı elde attik

            //kontrol noktası
            //Expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                default: // hiç bir koşul sağlanmıyorsa çalışacak kısım
                    Console.WriteLine("Yanlış giriş.");
                    break;
                    
            }


            switch (month)
            {  //birden fazla koşulda aynı kodu çalıştırırken : 
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış aylarındasınız");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar aylarındasınız");
                    break;    
                default:
                    Console.WriteLine("Yaz aylarındasınız");
                    break;
            }    
        }
    }
}
