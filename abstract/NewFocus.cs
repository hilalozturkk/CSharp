namespace abstract_
{

    public class NewFocus : Otomobil{

        public override Marka HangiMarkanınAracı() //tek bir metodu override etmem yeterli oldu abstract olsaydı tüm özellikleri tanımlamak zorundaydım -> kod kalabalığından kurtulduk
        
        {
            return Marka.Ford;
        }
    }


}