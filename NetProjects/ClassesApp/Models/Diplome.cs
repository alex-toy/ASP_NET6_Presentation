namespace ClassesApp.Models;

internal class Diplome
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Code { get; set; }
    public List<Promotion> Promotions { get; set; } = new List<Promotion>();

    public override string ToString()
    {
        return $"Diplome : {Nom} ({Code})";
    }

    public void Display()
    {
        Console.WriteLine(this);
        foreach (Promotion promotion in Promotions)
        {
            Console.WriteLine(promotion);
            foreach (Eleve eleve in promotion.Eleves)
            {
                Console.WriteLine(eleve);
            }
        }
    }
}
