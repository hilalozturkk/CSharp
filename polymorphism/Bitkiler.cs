using System;

namespace polymorphism
{
    public class Bitkiler : Canlılar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
        public override void UyaranlaraTepki() // kalıtım aldığımız classın metodunu istediğimiz şekilde kullanmak için override ettik
        {
            base.UyaranlaraTepki(); 
            Console.WriteLine("Bitkiler güneşe tepki verir");
        }
    }
  
  
  
    public class TohumluBitkiler : Bitkiler
    {
        //base bana miras veren üst sınıfların metotlarına erişme şansı verir
        public TohumluBitkiler()
        {
            base.Fotosentez();  // bitkiler sınıfının metodunu kullanmak için
                                //base.Beslenme();    // canlılar sınıfının protected metodunu kullanmak için 
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki(); //override ettiğim metodu nesnem oluştuğunda çalışmasını istiyorum

        }
        public void TohumIleCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler  tohumla çoğalır.");
        }
    }



    public class TohumsuzBitkiler : Bitkiler
    {

        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler  sporla çoğalır.");
        }
        public TohumsuzBitkiler()
        {
            base.Fotosentez();  // bitkiler sınıfının metodunu kullanmak için
            base.Beslenme();//base.Beslenme();    // canlılar sınıfının protected metodunu kullanmak için 
            base.Bosaltim();
            base.Solunum();
        }

    }
}