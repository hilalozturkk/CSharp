namespace Interface_ornek
{
    public class Focus : IOtomobil 
    {

            public Marka HangiMarkanınAracı(){
                    return Marka.Ford;
            }
             public Renk StandartRengiNe(){
                 return Renk.Beyaz;
            }
            public int KacTekerlektenOLusur(){
                return 4;
            }

    }

}