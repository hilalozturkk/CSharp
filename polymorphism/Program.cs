using System;

namespace polymorphism
{
// çok biçimcililik -> override ile yeniden metot yazabiliriz
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumlubitki = new TohumluBitkiler();
            tohumlubitki.TohumIleCogalma();

            Console.WriteLine("*******************");
            Kuslar martı = new Kuslar();
            martı.Ucmak();


        }

    }
}




