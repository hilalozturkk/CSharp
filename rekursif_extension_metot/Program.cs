using System;

namespace rekursif_extension_metot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Özyinelemeli
            int result = 1;
            for (int i = 1; i < 5; i++) //3^4
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Islemler instance = new Islemler();
            Console.WriteLine(instance.Expo(3, 4));

            //Extension Metotlar -> çok kullandığımız bir fonksiyonu extension a dönüştürebiliriz

            string ifade = "Hilal Öztürk";
            bool bosluk = ifade.CheckSpaces();
            Console.WriteLine(bosluk);

            if (bosluk)
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.MakeUpperCase());

            Console.WriteLine(ifade.MakeLowerCase());


            int[] dizi = {1,7,4,2,6,9,3,5};
            dizi.SortArray();

            foreach (var item in dizi) 
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Islemler
    {
        public int Expo(int sayi, int us)
        { // sayi 3 us 4

            if (us < 2)
            {// us 1 olduğunda sayi = kendisi olarak dönüyor
                return sayi;
            }
            return Expo(sayi, us - 1) * sayi; //iç içe çarpıyor 1 geldiğinde çıkıyor
        }


    }
    public static class Extension
    {//Extenion class lar ve metotlar static olmalı
        public static bool CheckSpaces(this string param) // boşluk  tespiti için extension metot
        { //this eklediğimde bu extension metot olur
            return param.Contains(" ");//içeriyor mu?
        }

        public static string RemoveWhiteSpaces(this string param)
        {

            string[] dizi = param.Split(" "); //boşluk gördüğün yerlerden stringi böl dizi elemanı olarak ata
            return string.Join("", dizi);//aralarında boşluk olmadan dizi elemanlarını birleştir

        }

        public static string MakeUpperCase(this string param)
        {//tüm ifadeyi büyük harf olarak yazdırırız
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {//tüm ifadeyi küçük harf olarak yazdırırız
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param){
                Array.Sort(param);
                return param;
        }
    }
}
