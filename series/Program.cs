using System;

namespace series
{
    class Program
    {
        static void Main(string[] args)
        {
            // dizi elemanları aynı tipte olur
            // dizi tanımlama : 

            string[] renkler = new string[5]; //sadece boyutunu belirtip elaman atamadan tanımlama

            string[] hayvanlar = { "Kedi", "Köpek", "Maymun" };    //boyut ve elemanlar belli tanımlama

            //alt alta tanımlama
            int[] dizi;
            dizi = new int[5];

            // dizilere değer atama ve erişim

            renkler[0] = "Mavi"; //0. indexe atama yaptık
            Console.WriteLine(hayvanlar[1]); // 1. indexe erişim

            dizi[3] = 10;
            Console.WriteLine(dizi[3]);

            Console.WriteLine(renkler[0]);

            // Döngülerle dizi kullanımı
            // n sayının ortalaması :

            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());

            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("lütfen {0}. sayısı giriniz ", i + 1); //{} içine atama gerçekleşiyor
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam  = 0;
            foreach (var item in sayiDizisi)
            {
                toplam += item;
            }
            Console.WriteLine("Ortalama : "+ toplam/diziUzunlugu);



        }
    }
}
