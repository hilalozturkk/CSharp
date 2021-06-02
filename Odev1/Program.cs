using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : 
            Console.WriteLine("Pozitif bir sayı giriniz ..");
            int diziUzunlugu = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Bir sayı giriniz :");
                dizi[i] += Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Girmiş olduğunuz çift sayılar : ");
            foreach (var item in dizi)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " , ");
                }
            }
            Console.WriteLine();




            // 2 :
            Console.WriteLine("Sırayla 2 sayı girişi yapınız : ");

            int diziUzunlugu1;
            int rastgeleGirilenSayi;

            diziUzunlugu1 = Convert.ToInt32(Console.ReadLine()); //1. sayı dizi uzunluğu olacak
            rastgeleGirilenSayi = Convert.ToInt32(Console.ReadLine()); //aranacak olan sayı

            int[] dizi1 = new int[diziUzunlugu1];

            for (int i = 0; i < diziUzunlugu1; i++)
            {
                Console.Write("Bir sayı giriniz :");
                dizi1[i] += Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("İkinci girilen sayıya tam bölünen ya da eşit olan sayılar: ");
            foreach (var item in dizi1)
            {
                if (item % rastgeleGirilenSayi == 0)
                {
                    Console.Write(item + " , ");
                }
            }
            Console.WriteLine();





            // 3 :
            Console.WriteLine("Bir sayı giriniz : ");
            int diziUzunlugu2 = Convert.ToInt32(Console.ReadLine());
            string[] dizi2 = new string[diziUzunlugu2];
            for (int i = 0; i < diziUzunlugu2; i++)
            {
                Console.Write("Bir kelime giriniz : ");
                dizi2[i] = Console.ReadLine();
            }
            Array.Reverse(dizi2);
            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }




            // 4 :
            Console.WriteLine("Bir cümle yazınız :");
            string cumle = Console.ReadLine();
            int toplamKelimeSayisi;
            int toplamHarfSayisi;

            string[] dizi3 = cumle.Split(" ");
            toplamKelimeSayisi = dizi3.Length;
            string cumle2 = string.Join("", dizi3);
            toplamHarfSayisi = cumle2.Length;

            Console.WriteLine("Toplam kelime sayısı : " + toplamKelimeSayisi + " Toplam harf sayısı : " + toplamHarfSayisi);



        }
    }
}
