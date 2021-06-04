using System;

namespace enum_
{
    class Program
    {
        static void Main(string[] args)
        {
            // sıralı veriler 
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.CUmartesi);//numeric değerine ulaştık

            int sicaklik = 24;
            
             if (sicaklik <= (int)HavaDurumu.Normal)//sicaklık normalin altındaysa
            {
                Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekle");
            }
            
            else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSıcak )
            {
                Console.WriteLine("Hadi dışarıya çıkalım");
            }
            else if(sicaklik >= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için sıcak bir gün");
            }
         
        }
    }
    enum Gunler //sabit değerleri tutmak için burada tutabiliriz
    {
        Pazartesi = 1, //elemanımın adı
        Sali,
        Çarşamba,
        Perşembe,
        Cuma,
        CUmartesi,
        Pazar
    }
    enum HavaDurumu{
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSıcak = 30
    }
}
