namespace L5;

public class UptAmenda : IAmenda
{
    public decimal calcAmenda(int zileIntarziate)
    {
        if (zileIntarziate <= 0)
            return decimal.Zero;
        
        var pretPeZi = 5.50m;
        
        return zileIntarziate * pretPeZi;
    }
}