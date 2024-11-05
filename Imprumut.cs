namespace L5;

public class Imprumut
{
    private IAmenda _amendaCalc;
    private readonly Carte _carte;
    private readonly Student _student;
    private readonly DateTime _dataImprumut;
    private DateTime _dataReturnare;

    public Imprumut(
        IAmenda amendaCalc,
        Student student,
        Carte carte,
        DateTime dataImprumut)
    {
        _amendaCalc = amendaCalc;
        _student = student;
        _carte = carte;
        _dataImprumut = dataImprumut;
    }

    public void ReturnareCarte(DateTime dataReturnare)
    {
        _dataReturnare = dataReturnare; 
        var zileIntarziere = (_dataReturnare - _dataImprumut).Days - _carte.ZileMaxDeImprumut;
        var amenda = _amendaCalc.calcAmenda(zileIntarziere);
        
        Console.WriteLine($"Pret imprumut carte: {_carte.PretImprumut}");
        if (zileIntarziere > 0)
            Console.WriteLine($"Zile intarzire: {zileIntarziere}. Amenda depasire zile: {amenda}");
        Console.WriteLine($"{_student.Nume} are un total plata: {_carte.PretImprumut + amenda} RON");
    }
}