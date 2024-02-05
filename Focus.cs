namespace Interface;

public class Focus : IOtomobil
{
    public Marka HangiMarkanınAraci()
    {
        return Marka.Ford;
    }

    public int KactekerlektenOlusur()
    {
        return 4;
    }

    public Renk StandartRengiNe()
    {
        return Renk.Beyaz;
    }
}
