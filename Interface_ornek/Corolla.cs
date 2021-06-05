namespace Interface_ornek
{
    public class Corolla : IOtomobil 
    {

            public Marka HangiMarkanınAracı(){
                    return Marka.Toyota;
            }
             public Renk StandartRengiNe(){
                 return Renk.Gri;
            }
            public int KacTekerlektenOLusur(){
                return 4;
            }

    }

}