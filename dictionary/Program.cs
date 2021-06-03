using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        { // anahtar değer olarak  - > her key farklı 
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(10, "ayşe");
            kullanıcılar.Add(18, "ibrahim");
            kullanıcılar.Add(34, "hakan");
            kullanıcılar.Add(54, "elif");


            //elemanlara ulaşım :
            Console.WriteLine(kullanıcılar[18]);// key=18 olan değeri gönder
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //count : boyut
            Console.WriteLine(kullanıcılar.Count);

            //contains -> var mı

            Console.WriteLine(kullanıcılar.ContainsKey(18));//true
            Console.WriteLine(kullanıcılar.ContainsValue("ayşe")); //true

            //Remove 
            kullanıcılar.Remove(34);


            //Keys: sadece keyleri yazdıracak

            foreach (var item in kullanıcılar.Keys) 
            {
                Console.WriteLine(item);
            }
            //Values: sadece değerleri yazdıracak

            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }



        }
    }
}
