namespace abstract_
{

    public abstract class Otomobil
    {
        public int KacTekerlektenOLusur()
        {
            return 4; //tüm sınıflar 4 cevabını kullanacak
        }

        public virtual Renk StandartRengiNe() // defaul 
        {
            return Renk.Beyaz;
        }

        public abstract Marka HangiMarkanınAracı();   
        //abstract metot olarak tanımlamamaızın nedeni alt sınıfların bunu implement etmeye ve gövdesini doldurmaya zorlamışş oluyoruz 



    }



}