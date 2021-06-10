using System;

namespace abstract_
{   // sadece kalıtım için kullanılır -> 
    class Program
    {
        static void Main(string[] args)
        {
           Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkanınAracı().ToString());
            Console.WriteLine(focus.KacTekerlektenOLusur().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Console.WriteLine("----------------------------");
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkanınAracı().ToString());
            Console.WriteLine(civic.KacTekerlektenOLusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Console.WriteLine("----------------------------");
            NewFocus newFocus = new NewFocus();
             Console.WriteLine(newFocus.HangiMarkanınAracı().ToString());
            Console.WriteLine(newFocus.KacTekerlektenOLusur().ToString());
            Console.WriteLine(newFocus.StandartRengiNe().ToString());

            Console.WriteLine("----------------------------");
            NewCivic newCivic = new NewCivic();
             Console.WriteLine(newCivic.HangiMarkanınAracı().ToString());
            Console.WriteLine(newCivic.KacTekerlektenOLusur().ToString());
            Console.WriteLine(newCivic.StandartRengiNe().ToString());
        }
    }
}
