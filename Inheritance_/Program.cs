using System;

namespace Inheritance_
{
    class Program
    {
        static void Main(string[] args)
        {// sadece kalıtım aldığı sınıftan erişilebilmeyi sağlar -> protected
            TohumluBitkiler tohumlubitki = new TohumluBitkiler();
            /*  tohumlubitki.Beslenme(); //canlılar classından geldi
              tohumlubitki.Solunum();
              tohumlubitki.Bosaltim();
              tohumlubitki.Fotosentez(); //bitkiler classı  */
            tohumlubitki.TohumIleCogalma();

            Kuslar martı = new Kuslar();
            /*   martı.Solunum();//hayvanlar class
               martı.Beslenme();
               martı.Bosaltim();
                martı.Adaptasyon(); */
            martı.Ucmak(); //Kuşlar class


        }

    }




}
