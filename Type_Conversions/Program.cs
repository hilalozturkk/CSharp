using System;

namespace Type_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
         //Implicit Conversion -> bilinçsiz dönüşüm
        //dönüşüm yapmamıza gerek kalmadan gerçekleşir
        byte  a = 5 ;
        sbyte b = 30;
        short c =10;

        int d= a+b+c;
        Console.WriteLine("d : "+d);//45

         long h = d;
        Console.WriteLine("h : "+h);//45

        float f= d;
        Console.WriteLine("f : "+f);//45

        string e = "hilal";
        char g = 'f';
        int k = 2;
        object o = e+g+k; //hilalf2

        Console.WriteLine("o : "+o);//tüm veri tipleri objectten türediği için hata almayız




        //Explicit COnversion -> bilinçli dönüşüm 
        //Convert - Parse

        //bu tip dönüşümlerde veri kaybı yaşanabilir
        int x = 4;
        byte y = (byte)x;//byte dönüştür
        Console.WriteLine(y);

        int z = 100;
        byte t = (byte)z;
        Console.WriteLine(t);

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine(v);

        //ToString()

        int xx = 6;
        string yy  = xx.ToString(); // string değere çevirir
        Console.WriteLine("yy : "+yy);

        string zz  = 12.5f.ToString(); // string değere çevirir
        Console.WriteLine("zz : "+zz);

        //System.Convert


        string s1 = "10", s2 = "20";
        int sayi1, sayi2, Toplam;
        
        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);

        Toplam = sayi1+sayi2;

        Console.WriteLine(Toplam);//30


        //Parse yanlızca string ifadeleri dönüştürür

        string metin1 = "10";
        string metin2 = "10,25";
        int rakam;
        double double1;
        
        rakam = Int32.Parse(metin1);    //10
        double1 = Double.Parse(metin2); //10.25

        Console.WriteLine("rakam: "+rakam+" double1 :"+ double1);
        }
    }
}
