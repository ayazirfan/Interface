namespace Interface;

public class Civic : IOtomobil
{
    public Marka HangiMarkanınAraci()
    {
        return Marka.Honda;
    }

    public int KactekerlektenOlusur()
    {
        return 4;
    }

    public Renk StandartRengiNe()
    {
        return Renk.Gri;
    }
}
