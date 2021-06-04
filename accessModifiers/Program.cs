using System;


namespace accessModifiers

// bir nesne oluşturduğumuzda otamatik oluşan metoda kurucu metot denir
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Hilal", "Soyad", 396, "İnsan kaynakları");
  
            calisan1.CalisanBilgileri();
            Console.WriteLine("*******************");


            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Hilal";
            calisan2.Soyad = "Soyad";
            calisan2.No = 396;
            calisan2.Departman = "İnsan kaynakları";

            calisan2.CalisanBilgileri();

            Console.WriteLine("*******************");
            Calisan calisan3 = new Calisan("Hilal", "Soyad");
  
            calisan3.CalisanBilgileri();
        }
    }




    class Calisan
    {
        public string Ad;
        public string Soyad;

        public int No;

        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
           
        }

        public Calisan(){

        }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan No:{0}", No);
            Console.WriteLine("Çalışan Departman:{0}", Departman);
        }

    }
}


