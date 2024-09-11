namespace POOApp.Models;

public class Diplome
{
    public string Code { get; init; }
    public string Libelle { get; init; }
    public int Niveau { get; init; }

    public Diplome(string code, string libelle, int niveau)
    {
        Code = code;
        Libelle = libelle;
        Niveau = niveau;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is Diplome diplome) return Code == diplome.Code && Libelle == diplome.Libelle && Niveau == diplome.Niveau;
        return false;
    }

    public override int GetHashCode()
    {
        return 23 + Code.GetHashCode();
    }

    public override string ToString()
    {
        return $"{Code} {Libelle} {Niveau}";
    }
}
