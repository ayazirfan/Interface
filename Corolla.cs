namespace Interface;

public class Corolla : IOtomobil
{
    public Marka HangiMarkanınAraci()
    {
        return Marka.Toyota;
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
