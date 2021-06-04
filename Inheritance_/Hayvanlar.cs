using System;

namespace Inheritance_
{
    public class Hayvanlar : Canlılar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
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
        }
    }
}