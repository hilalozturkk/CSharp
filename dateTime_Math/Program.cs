using System;

namespace dateTime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);         // bugün tarihi
            Console.WriteLine(DateTime.Now.Date);    //sadece tarih

            Console.WriteLine(DateTime.Now.DayOfWeek);//haftanın gününü getirir
            Console.WriteLine(DateTime.Now.DayOfYear);//yılın kaçıncı günündeyim

            Console.WriteLine(DateTime.Now.ToLongDateString());//uzun yazılmış tarih
            Console.WriteLine(DateTime.Now.ToShortDateString());//kısa yazılmış tarih

            //longtime ->saat dakika saniye  shorttime -> sadace  saat dakika

            Console.WriteLine(DateTime.Now.AddMonths(2));//bugunden sonra 2 ay ekle

            //DateTime format -> d day, M month, y year 
            Console.WriteLine(DateTime.Now.ToString("dd")); //03
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Per
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Perşembe

            Console.WriteLine(DateTime.Now.ToString("MM")); //06
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Haz
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //Haziran


            Console.WriteLine(DateTime.Now.ToString("yyy")); // 21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021


            //Math
            Console.WriteLine(Math.Abs(-25));//mutlak değeri verir
            Console.WriteLine(Math.Sin(10));//sin cos tan


            Console.WriteLine(Math.Ceiling(22.3));// byukarı yuvarla -> 23
            Console.WriteLine(Math.Round(22.3));  // hangisine daha yakın ->22
            Console.WriteLine(Math.Floor(22.7));  // aşağı yuvarla -> 22

            Console.WriteLine(Math.Max(2, 6));//max hangisi
            Console.WriteLine(Math.Min(2, 6));

            //pow üssü işlemi    sqrt karekök  
            //Log logaritmik karşılık  Log10 log10 tabanında 


        }
    }
}
