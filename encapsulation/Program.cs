using System;

namespace encapsulation
{

    class Program
    {
        static void Main(string[] args)
        {
           Ogrenci ogrenci1 = new Ogrenci("Hilal","Ozturk",396,4);
           ogrenci1.OgrenciBilgileri();
            Console.WriteLine("***********************");
           ogrenci1.SinifAtlat();
           ogrenci1.OgrenciBilgileri();
        }
    }


    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get => sinif; 
            set { 
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabiliri");
                    sinif = 1;   
                }
                else
                    sinif = value; 
            }
            }

        public Ogrenci() { }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.OgrenciNo = ogrenciNo;
            this.Sinif = sinif;
        }

        public void OgrenciBilgileri()
        {
            Console.WriteLine("Öğrenci adı :          {0}", this.Isim);
            Console.WriteLine("Öğrenci soyadı :       {0}", this.Soyisim);
            Console.WriteLine("Öğrenci nosu :         {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci sınıfı :       {0}", this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }


    }
}