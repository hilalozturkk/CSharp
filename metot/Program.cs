using System;

namespace metot
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            *   static bir class içinden sadece static metotlara erişilebilir
            */
            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);//5

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);//5

            Metotlar ornek = new Metotlar();
            ornek.ekranaBatir(Convert.ToString(sonuc));//5

            sonuc = ornek.ArttırVeTopla(ref a, ref b); // a ve b değeri +1 oldu
            ornek.ekranaBatir(Convert.ToString(sonuc));//7

            ornek.ekranaBatir(Convert.ToString(a + b));// a ve b değerini global olarak değiştirdik = 7

        }
        static int Topla(int deger1, int deger2) //call by value
        {
            return (deger1 + deger2);
        }

    }
    class Metotlar
    {
        public void ekranaBatir(string veri)//default private 
        {
            Console.WriteLine(veri);
        }
        public int ArttırVeTopla(ref int deger1, ref int deger2)
        { //call by reference

            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;

        }
    }
}
