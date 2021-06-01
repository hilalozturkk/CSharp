using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            //diziler array sınıfından türüyor
            //sort - sıralama
            int[] sayi = { 23, 13, 56, 97, 46, 7, 34, 50 };

            Console.WriteLine("Sırasız");
            foreach (var item in sayi)
                Console.WriteLine(item);

            Console.WriteLine("Sıralı");
            Array.Sort(sayi);

            foreach (var item in sayi)
                Console.WriteLine(item);


            Console.WriteLine("Clear metodu uygulandı : ");
            //clear  belirlediğimiz indexten kaç adet ise o kısımlara 0 atar
            Array.Clear(sayi, 3, 1); //yanlızca 3. indexi 0 yaptık
            foreach (var item in sayi)
                Console.WriteLine(item);

            //Reverse - tersine çevirir diziyi
            Console.WriteLine("Reverse uygulanmış dizi : ");
            Array.Reverse(sayi);
            foreach (var item in sayi)
            {
                Console.WriteLine(item);
            }

            //indexof - dizide eleman arama
            Console.WriteLine("Indexof ile eleman arama");
            Console.WriteLine(+Array.IndexOf(sayi, 13));//yoksa -1 varsa indexini döndürür

            //resize - yeniden boyutlandırma yapar
            Console.WriteLine("Resize metpdu kullanıldı");
            Array.Resize<int>(ref sayi, 15); //atama yapmadığım elemanlar 0 olarak görünür

            sayi[8] = 10;

            foreach (var item in sayi)
            {
                Console.WriteLine(item);
            }


        }
    }
}
