namespace LinqAppContext.Context;

internal class Diplome
{
    public string Code { get; set; }
    public string Nom { get; set; }
    public int Niveau { get; set; }
    public List<Promotion> Promotions { get; set; } = new List<Promotion>();

    public override string ToString()
    {
        return Nom;
    }
}
