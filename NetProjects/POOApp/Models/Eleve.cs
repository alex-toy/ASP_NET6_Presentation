namespace POOApp.Models;

public class Eleve
{
    public string Nom { get; init; }
    public string Prenom { get; init; }
    public Promotion Promotion { get; init; }

    public Eleve(string nom, string prenom, Promotion promotion)
    {
        Nom = nom;
        Prenom = prenom;
        Promotion = promotion;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is Eleve eleve) return Nom == eleve.Nom && Prenom == eleve.Prenom && Promotion.Equals(eleve.Promotion);
        return false;
    }

    public override int GetHashCode()
    {
        return 23 + Nom.GetHashCode() + Prenom.GetHashCode();
    }

    public override string ToString()
    {
        return $"{Nom} {Prenom} {Promotion}";
    }
}
