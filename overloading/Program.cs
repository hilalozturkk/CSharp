using System;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler 
            string sayi = "999";
            //tryparse doğu şekilde çevrilip çevrilmediği konusunda kullanılır
            int outSayi;

            bool sonuc = int.TryParse(sayi, out outSayi); //doğru şekilde geldi mi? 1. kullanım

            if (sonuc)
            {
                Console.WriteLine("Başarılı giriş");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız...");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(4, 7, out int toplam);//toplam değişkenine atamış olduk 2. kullanım
            Console.WriteLine(toplam);

            //Metot Aşırı Yükleme overloading

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("hilal", " öztürk");
        }
    }
    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }
        //overloading metotlar ->
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri, string veri1)
        {
            Console.WriteLine(veri + veri1);
        }
    }
}