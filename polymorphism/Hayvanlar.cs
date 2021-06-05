using System;

namespace polymorphism
{
    public class Hayvanlar : Canlılar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }
           public override void UyaranlaraTepki()
        {
           // base.UyaranlaraTepki(); // eğer burada çağırısak üst classın metodunu da çalıştıracak
           // çağırmazsak sadece override ettiğimizde istediğimiz çalışır =
            Console.WriteLine(  " Hayvanlar temasa tepki verir");
        }
    }



    public class Surungenler : Hayvanlar //hayvanlar classından kalıtım aldık
    {
        public void SurungenlerHareketEderler()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
        public Surungenler()
        { //hayvanlar classında protected metodu kurucuda yazdım
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }

     
    }



    public class Kuslar : Hayvanlar
    {
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar.");
        }

        public Kuslar()
        { //hayvanlar classında protected metodu kurucuda yazdım
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
    }
}
