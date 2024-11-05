namespace L5;

public class VestAmenda : IAmenda
{
    public decimal calcAmenda(int zileIntarziate)
    {
        if (zileIntarziate <= 0)
            return decimal.Zero;
        
        var pretPeZi = 2.50m;
        
        return zileIntarziate * pretPeZi;
    }
}