using LinqAppContext.Context;

AnnuaireContext context = new AnnuaireContext();

var promotionsForDiplomaCDA = context.Promotions.Where(p => p.Diplome.Code == "CDA").Select(p => new
{
    Diplome = p.Nom,
    EleveCount = p.Eleves.Count(),
}).ToList();

promotionsForDiplomaCDA.ForEach(diploma =>
{
    Console.WriteLine($"{diploma.Diplome} - {diploma.EleveCount}");
});

//var eleveCountPerDiploma = context.Eleves.GroupBy(e => e.Promotion.Diplome, e => e, (dip, eleve) => new
//{
//    Diplome = dip.Nom,
//    EleveCount = eleve.Count()
//}).ToList();

//eleveCountPerDiploma.ForEach(diploma =>
//{
//    Console.WriteLine($"{diploma.Diplome} - {diploma.EleveCount}");
//});

//Console.WriteLine("*******************************");

//var eleveCountPerDiploma2 = context.Diplomes.Select(d => new
//{
//    Diplome = d.Nom,
//    EleveCount = d.Promotions.SelectMany(x => x.Eleves).Count(),
//    EleveCount2 = d.Promotions.Sum(x => x.Eleves.Count),
//}).ToList();

//eleveCountPerDiploma2.ForEach(diploma =>
//{
//    Console.WriteLine($"{diploma.Diplome} - {diploma.EleveCount} - {diploma.EleveCount2}");
//});


//var promotionCountPerDiploma1 = context.Promotions.GroupBy(p => p.Diplome, p => p, (dip, promo) => promo.Count()).ToList();

//promotionCountPerDiploma1.ForEach(diploma =>
//{
//    Console.WriteLine($"{diploma.ToString()}");
//});

//Console.WriteLine("***************************");
//List<int> promotionCountPerDiploma = context.Diplomes.Select(d => d.Promotions.Count).ToList();
//promotionCountPerDiploma.ForEach(p => Console.WriteLine(p));

//List<Diplome> diplomes = context.Diplomes.ToList();

//diplomes.ForEach(diploma =>
//{
//    Console.WriteLine($"{diploma.ToString()} Count : {diploma.Promotions.Count}");
//});



//List<Diplome> promotionLessDiplomas = context.Diplomes.Where(d => d.Promotions.Count == 0).ToList();

//promotionLessDiplomas.ForEach(diplome => Console.WriteLine(diplome));

//List<Promotion> promotions = context.Promotions.ToList();

//promotions.ForEach(p =>
//{
//    Console.WriteLine(p);
//    Console.WriteLine(p.Eleves.Count);
//});

//List<int> promotionsPupilsCount = context.Promotions.Select(p => p.Eleves.Count).ToList();

//promotionsPupilsCount.ForEach(p => Console.WriteLine(p));

//List<Promotion> promotionsWithAtLeastOnePupil = context.Promotions.Where(p => p.Eleves.Count > 0)
//                                                                  .OrderByDescending(p => p.Eleves.Count)
//                                                                  .ToList();

//promotionsWithAtLeastOnePupil.ForEach(p => Console.WriteLine(p));

//List<Eleve> elevesCDA = context.Eleves.Where(e => e.Promotion.Diplome.Code == "CDA").ToList();

//elevesCDA.ForEach(eleve =>
//{
//    Console.WriteLine(eleve);
//    Console.WriteLine(eleve.Promotion);
//});



