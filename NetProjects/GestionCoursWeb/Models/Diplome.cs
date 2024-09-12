using System.ComponentModel.DataAnnotations;

namespace GestionCoursWeb.Models;

public class Diplome
{
    [Key]
    public int Id { get; set; }
    public string Code { get; set; }
    public string Nom { get; set; }
    public int Niveau { get; set; }
    public List<Promotion> Promotions { get; set; } = new List<Promotion>();

    public override string ToString()
    {
        return Nom;
    }
}
