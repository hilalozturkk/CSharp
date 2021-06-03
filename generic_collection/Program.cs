using System;
using System.Collections.Generic;


namespace generic_collection
{
    // koleksiyonlarda -> farklı veri tipleri ile çalışılabilir, dinamik boyut, her nesne tipi object
    // kolaksiyona eleman eklerken -> boxing yaparız 
    class Program
    {
        static void Main(string[] args)
        {
            //List<T>  class
            //T generic -> object türündedir ve nesne alabilir,
            //listenin içindeki nesnelerin tipini ifade eder

            //int bir liste ->

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(2);


            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");


            //Count -> kaç eleman var 
            Console.WriteLine(sayiListesi.Count);

            // forEach ve List.ForEach ile elemanlara erişim : 
            foreach (var item in sayiListesi)
            {
                Console.WriteLine(item);
            }

            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(2);
            renkListesi.RemoveAt(0); // index e göre

            //liste içerisinde arama

            if (sayiListesi.Contains(23))
            {
                Console.WriteLine("23 listede Bulundu");
            }

            //elemanın indexine erişme

            Console.WriteLine(renkListesi.BinarySearch("Mavi"));

            //diziyi listeye çevirme

            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //listeyi nasıl temizleriz

            hayvanListesi.Clear();

            //Liste içerisinde nesne tutmak

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim="hilal";
            kullanıcı1.Soyisim ="öztürk";
            kullanıcı1.Yas=23;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim="hilal";
            kullanıcı2.Soyisim ="öztürk";
            kullanıcı2.Yas=23;
    
            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            // listeye kullanıcı atamanın başka bir yolu : 
            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            //kullanıcılar sınıfının bir örneğini oluştururuz
            yeniListe.Add(new Kullanıcılar(){
                Isim ="hilal",
                Soyisim = "öztürk",
                Yas = 23
            });

            //elemanlarına nasıl erişiyoruz : 
            foreach (Kullanıcılar item in kullanıcıListesi)
            {
                Console.WriteLine(item.Isim + " " + item.Soyisim + " yas : "+ item.Yas);
            }
        }
    }

    public class Kullanıcılar
    {
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }

    }
}
