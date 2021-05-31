using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atamalar
            int y = 4;
            y += 2;    //y = 6 
            Console.WriteLine(y);
            y /= 2;     //y = 3
            Console.WriteLine(y);

            //Mantıksal opertörler

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted) //ikiside doğru &&
            {
                Console.WriteLine("Mükemmel");
            }

            if (isSuccess || isCompleted) //biri doğru ||
            {
                Console.WriteLine("İyi");
            }

            if (isSuccess && !isCompleted) // ! değili 
            {
                Console.WriteLine("Güzel");
            }


            //İlişkisel operatörler

            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);//true

            sonuc = a > b;
            Console.WriteLine(sonuc);//false

            sonuc = a == b;
            Console.WriteLine(sonuc);//false

            sonuc = a != b;
            Console.WriteLine(sonuc);//true

            //Aritmatik operatörler

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);//2
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);//15
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);//50
            sonuc1 = ++sayi1;
            Console.WriteLine(sonuc1);//11

            int sonuc2 =20%3;
            Console.WriteLine(sonuc2);//2
        }
    }
}
