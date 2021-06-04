using System;

namespace staticSinifveUyeler
{
    class Program
    {
        static void Main(string[] args)
        {  //static değişkenlere , metotlara nesne oluşturmadan erişiriz ve  kalıtım işlemi uygulanamaz
            // static olan elemanlara o sınıfın adıyla erişebiliriz
            // static olmayan özelliklere nesne aracılığyla erişiyoruz    
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);
            //CalisanSayisi değişkeni artık bir değişken gibi davranır


            Calisan calisan1 = new Calisan("Hilal", "Öztürk", "IK");
            //calisan1. dediğimizde özelliklere erişim sağlayamayız -> 'private'
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan2 = new Calisan("Hilal", "Öztürk", "IK");
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);


            Console.WriteLine("Toplama  :{0}", Islemler.Topla(15, 9));
            Console.WriteLine("Çıkartma :{0}", Islemler.Cikar(15, 9));
        }
    }
    class Calisan
    {
        private static int calisanSayisi; //static değişken  -> calisanSayisi sınıfa ait bir özellik gibi düşünülebilir

        public static int CalisanSayisi { get => calisanSayisi; } //encapsulation  -> set yapmadık çünkü sadece calisan classından değiştirmek istiyoruz.

        //static kurucu :
        static Calisan()
        {   //erişim belirteçleri olmaz
            calisanSayisi = 0;//olulturduğumda değeri 0 olarak atanıyor 

        }
        private string Isim;
        private string SoyIsim;
        private string Departman;

        public Calisan(string isim, string soyIsim, string departman)//cons.
        {
            this.Isim = isim;
            this.SoyIsim = soyIsim;
            this.Departman = departman;
            calisanSayisi++; // her nesne oluştuğunda calisanSayisi 1 artacak
        }
    }

    static class Islemler
    {//static class içinde tüm elemanlar static olur

        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }


        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

    }
}
