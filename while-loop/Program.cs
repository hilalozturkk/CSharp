using System;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen sayının ortanca elemanını bulma
            Console.Write("Sayi girişi : ");
            int sayi = int.Parse(Console.ReadLine());//10
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Ortalamanız : " + toplam / sayi);

            // a dan z ye kadar tüm harfleri consola yazdırma

            char character = 'a';
            while (character <= 'z')
            {
                Console.WriteLine(character);
                character++;
            }

            string[] arabalar  = {"BMV", "Ford", "Toyota", "Nissan"};

            foreach (var item in arabalar)
            {
             Console.WriteLine(item);   
            }
        }

    }
}
