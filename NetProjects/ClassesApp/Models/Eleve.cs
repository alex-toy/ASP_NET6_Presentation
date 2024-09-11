namespace ClassesApp.Models;

internal class Eleve
{
    public int Id { get; set; }
    public string Prenom { get; set; } = string.Empty;
    public string Nom { get; set; } = string.Empty;
    public Promotion Promotion { get; set; }

    public override string ToString()
    {
        return $"{Nom} {Prenom}";
    }
}
