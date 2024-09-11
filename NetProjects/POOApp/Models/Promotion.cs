namespace POOApp.Models;

public class Promotion
{
    public string Code { get; init; }
    public string Nom { get; init; }
    public Diplome Diplome { get; init; }

    public Promotion(string code, string nom, Diplome diplome)
    {
        Code = code;
        Nom = nom;
        Diplome = diplome;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is Promotion promotion) return Code == promotion.Code && Nom == promotion.Nom && Diplome.Equals(promotion.Diplome);
        return false;
    }

    public override int GetHashCode()
    {
        return 23 + Code.GetHashCode();
    }

    public override string ToString()
    {
        return $"{Code} {Nom} {Diplome}";
    }
}
