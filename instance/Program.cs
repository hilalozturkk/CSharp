using System;

namespace instance
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Hilal";
            calisan1.Soyad = "Soyad";
            calisan1.No = 396;
            calisan1.Departman = "İnsan kaynakları";


            calisan1.CalisanBilgileri();
            Console.WriteLine("*******************");

            
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Hilal";
            calisan2.Soyad = "Soyad";
            calisan2.No = 396;
            calisan2.Departman = "İnsan kaynakları";

            calisan2.CalisanBilgileri();
        }
    }




    class Calisan
    {
        public string Ad;
        public string Soyad;

        public int No;

        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan No:{0}", No);
            Console.WriteLine("Çalışan Departman:{0}", Departman);
        }

    }
}
