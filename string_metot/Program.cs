using System;

namespace string_metot
{//string küphanesi metotları : 
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp hoşgeldiniz :";
            string degisken2 = "CSharp hoşgeldiniz :";

            //Lenght - > string değişkenin karakter sayısını verir 
            Console.WriteLine(degisken.Length);

            //ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat -> degişkenin sonuna ekleme  
            Console.WriteLine(String.Concat(degisken, "Merhaba !"));

            /* Compare  extra ignorecase özelliği vardır
            CompareTo -> degisken ile degisken2 yi karşılaştır karakter sayısı  eşitse 0 büyükse 1 küçükse -1
  */
            Console.WriteLine(degisken.CompareTo(degisken2)); //1 döndürür 
            Console.WriteLine(String.Compare(degisken, degisken2, false));
            Console.WriteLine(String.Compare(degisken, degisken2, true));

            //Contains -> içeriyor mu ?
            Console.WriteLine(degisken.Contains(degisken2));
            //EndsWith bitiyor mu - StartsWith başlıyor mu

            //indexof -> indexini döndürür, bulamazsa -1 döndürür
            Console.WriteLine(degisken.IndexOf("CS"));

            //lastindexof - > istenilen değerin en son kaçıncı indexte olduğunu döndürür
            Console.WriteLine(degisken.LastIndexOf("rp"));

            //insert -> degiskenin istediğimiz yere ekleme
            Console.WriteLine(degisken.Insert(0, "Merhaba "));

            //PadLeft, PadRight -> boşluk vermek istediğimizde
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken + degisken2.PadRight(30, '*'));

            //Remove ->
            Console.WriteLine(degisken.Remove(10));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split -> boşluklara göre parçala diziye ata
            Console.WriteLine(degisken.Split(" ")[1]);//boşluklara göre böldü 1. indexi döndürdü

            //Substring -> başlangıç ve bitiş noktaları verip döndürür 
            Console.WriteLine(degisken.Substring(4,7));
        }
    }
}