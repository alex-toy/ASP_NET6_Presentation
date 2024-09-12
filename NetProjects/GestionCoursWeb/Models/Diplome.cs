using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionCoursWeb.Models;

public class Diplome
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
