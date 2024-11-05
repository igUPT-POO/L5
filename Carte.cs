namespace L5;

public class Carte
{
    public string Isbn { get; set; }
    public string Titlu { get; set; }
    public string Autor { get; set; }
    public DateTime AnPublicare { get; set; }
    public decimal PretImprumut { get; set; }
    public int ZileMaxDeImprumut { get; set; }
}