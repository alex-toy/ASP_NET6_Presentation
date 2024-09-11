using POOApp.Models;

Diplome diplome1 = new Diplome("D1", "Developpeur", 1);
Diplome diplome2 = new Diplome("D1", "Developpeur", 1);
Diplome diplome3 = new Diplome("D3", "Developpeur", 1);
Diplome diplome4 = new Diplome("D1", "Developpeur", 2);

Console.WriteLine(diplome1.Equals(diplome2));
Console.WriteLine(diplome1.Equals(diplome3));
Console.WriteLine(diplome1.Equals(diplome4));

Console.WriteLine(diplome1 == diplome2);
Console.WriteLine(diplome1 == diplome3);
Console.WriteLine(diplome1 == diplome4);

Promotion promotion1 = new Promotion("P1", "promotion1", diplome1);
Promotion promotion2 = new Promotion("P1", "promotion1", diplome2);

Console.WriteLine(promotion1.Equals(promotion2));

Eleve eleve1 = new Eleve("alex", "dupond", promotion2);
Eleve eleve2 = new Eleve("alex", "dupond", promotion1);

Console.WriteLine(eleve1.Equals(eleve2));
