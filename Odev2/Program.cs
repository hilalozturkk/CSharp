using System;
using System.Collections;


namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1:

            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();

            Console.WriteLine("20 tane sayı girişi yapınız");



            try
            {
                for (int i = 0; i < 20; i++)
                {
                    int alinanSayi;
                    alinanSayi = Int32.Parse(Console.ReadLine());
                    if (alinanSayi < 2)
                    {
                        Console.WriteLine("Küçük bir sayı girdiniz.");
                        continue;
                    }


                    if (alinanSayi == 2 || alinanSayi == 3)
                    {
                        asalSayilar.Add(alinanSayi);
                    }

                    else if (alinanSayi % 2 == 0 || alinanSayi % 3 == 0)
                    {
                        asalOlmayanSayilar.Add(alinanSayi);
                    }

                    else
                    {
                        asalSayilar.Add(alinanSayi);
                    }

                }
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Veri tipi uygun verilmedi...");
                Console.WriteLine(ex);
            }

            finally
            {




                asalOlmayanSayilar.Sort();
                asalSayilar.Sort();

                Console.WriteLine("Asal olmayan sayilar :");
                foreach (var item in asalOlmayanSayilar)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Asal sayilar :");
                foreach (var item in asalSayilar)
                {
                    Console.WriteLine(item);
                }

                int asalToplam = 0;
                int asalOlmayanToplam = 0;
                foreach (var item in asalSayilar)
                {
                    asalToplam += int.Parse(item.ToString());
                }
                foreach (var item in asalOlmayanSayilar)
                {
                    asalOlmayanToplam += int.Parse(item.ToString());
                }

                Console.WriteLine
                (
                "Asal olmayan sayı dizisinin elaman sayısı : " + asalOlmayanSayilar.Count + "\n" +
                "Asal olmayan sayı dizisinin elemanlarının ortalaması : " + asalOlmayanToplam + "\n" + "Asal olan sayı dizisinin eleman sayısı : " + asalSayilar.Count + "\n" +
                 "Asal sayı dizisinin elemanlarının ortalaması :" + asalToplam
                );

            }



            //2:

            Console.WriteLine("----------------");
            Console.WriteLine("20 sayı girişi yapınız :");
            ArrayList newArray = new ArrayList();
            int alinanSayi1;
            for (int i = 0; i < 20; i++)
            {
                alinanSayi1 = Int32.Parse(Console.ReadLine());
                newArray.Add(alinanSayi1);
            }



            newArray.Sort();

            ArrayList enBuyuk = new ArrayList();
            int[] enKucuk = new int[3];

            for (int i = newArray.Count - 3; i <= newArray.Count - 1; i++)
            {
                enBuyuk.Add(int.Parse(newArray[i].ToString()));
            }

            for (int i = 0; i < 3; i++)
            {
                enKucuk[i] = int.Parse(newArray[i].ToString());
            }


            int enBuyukToplam = 0;
            int enKucukToplam = 0;

            foreach (var item in enBuyuk)
            {
                enBuyukToplam += int.Parse(item.ToString());
            }
            foreach (var item in enKucuk)
            {
                enKucukToplam += int.Parse(item.ToString());
            }

            Console.WriteLine("3 büyük sayının ortalamalası : " + enBuyukToplam / 3 + "\n3 küçük sayının ortalaması : " + enKucukToplam / 3 + "\nGirilen 20 sayının en büyük 3 sayının ve en küçük 3 sayının  ortalamalarının toplamı : " + ((enBuyukToplam / 3) + (enKucukToplam / 3)));


            //3:

            Console.WriteLine("--------------");
            Console.WriteLine("Bir cümle giriniz..");
            string metin = Console.ReadLine();
            string sesli = "aeıioöuü";

            int sayac = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                //karakter katarkter kontrol ediyoruz.
                if (sesli.Contains(metin[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine(metin);
            Console.WriteLine("Yukarıdaki ifadede toplam {0} tane sesli harf vardır.", sayac);

        }

    }

}


