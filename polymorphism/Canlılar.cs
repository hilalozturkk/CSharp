using System;

namespace polymorphism
{
    public /*sealed yazarsam kalıtım veremez*/class Canlılar 
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım yapar");
        }
        //virtual metot yazıyoruz  -> virtual olarak işaretledik
        public virtual void UyaranlaraTepki (){
            Console.WriteLine("Canlılar uyaranlara tepki verir");
        }
    }
}