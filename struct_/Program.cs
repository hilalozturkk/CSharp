using System;

namespace struct_
{
    class Program
    {
        static void Main(string[] args)
        {// struct ların yapıları class lara çok benzer 
         // kendi metotları , özellikleri vardı ,kurucuları vardır
         // struct yapısını küçük verilerde çok fazla veri saklamayacaksak kullanırız -> performansı arttırır

            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 2;
            dikdortgen.UzunKenar = 5;

            Console.WriteLine("Class Alan Hesabı : {0}", dikdortgen.AlanHesapla());

            //struct nesnesi :
            Dikdortgen_Struct dikdortgen_Struct ;//new yazmamıza gerek yok
            dikdortgen_Struct.KisaKenar = 3;
            dikdortgen_Struct.UzunKenar = 5;

            Console.WriteLine("Struct Class Alan Hesabı : {0}", dikdortgen_Struct.AlanHesapla());
        }
    }
    class Dikdortgen
    {
// default kurucuyu kendimiz tanımlayabiliriz
        public int KisaKenar;
        public int UzunKenar;
        public long AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }

    //struct class tanımlama :  -> eğer kurucu yazacaksak parametre vermek zorundayız 
    struct Dikdortgen_Struct
    { 
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen_Struct(int kisaKenar, int uzunKenar){ //kurucu yapısı böyle olmalı
                KisaKenar = kisaKenar;
                UzunKenar = uzunKenar;
        }

        public long AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }

    }
}
