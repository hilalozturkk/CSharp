using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{//birden fazla veri tipi saklanabilir
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Ayşe");
            list.Add(2);
            list.Add(true);
            list.Add('s');


            //içerisindeki verilere erişim :
            Console.WriteLine(list[1]);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //AddRange -> birden fazla elemanı toplu halde nasıl ekleriz ?
            string[] renkler = { "kırmızı", "mavi" };
            List<int> sayilar = new List<int>() { 1, 5, 3, 6, 4, 4 };
            list.AddRange(renkler);//dizi ekledik
            list.AddRange(sayilar);//generic ekledik

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Sort -> sayilara göre sıralar
            //list.Sort();

            //BinarySearch -> sıralama yapıldıktan sonra doğru çalışıyor 

            //Console.WriteLine(list.BinarySearch(3));

            //Reverse tersini sıralar

            //clear -Z listeyi temizler











        }
    }
}
