namespace ClassesApp.Models;

internal class Promotion
{
    public int Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public List<Eleve> Eleves { get; set; } = new List<Eleve>();
    public Diplome Diplome { get; set; }

    public override string ToString()
    {
        return $"Promotion : {Nom} ({Eleves.Count} élèves)";
    }
}
