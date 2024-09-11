using ClassesApp.Models;
 
Diplome cda = new Diplome() { Code = "CDA", Nom = "Concepteur Developpeur d'application" };

Promotion cda001 = new Promotion { Id = 1, Nom = "CDA001", Diplome = cda };
Promotion cda002 = new Promotion { Id = 2, Nom = "CDA002", Diplome = cda };
cda.Promotions.AddRange(new List<Promotion>() { cda001, cda002 });

Eleve eleve1 = new Eleve() { Id = 1, Nom = "Lavrov", Prenom = "alex", Promotion = cda001 };
Eleve eleve2 = new Eleve() { Id = 2, Nom = "Volkov", Prenom = "seb", Promotion = cda001 };
cda001.Eleves.AddRange(new List<Eleve>() { eleve1, eleve2 });

Eleve eleve3 = new Eleve() { Id = 3, Nom = "Lebedev", Prenom = "kate", Promotion = cda002 };
Eleve eleve4 = new Eleve() { Id = 4, Nom = "Magomedov", Prenom = "sergei", Promotion = cda002 };
cda002.Eleves.AddRange(new List<Eleve>() { eleve3, eleve4 });



Diplome cdb = new Diplome() { Code = "CDB", Nom = "Concepteur Developpeur d'application" };

Promotion cdb001 = new Promotion { Id = 1, Nom = "CDB001", Diplome = cdb };
Promotion cdb002 = new Promotion { Id = 2, Nom = "CDB002", Diplome = cdb };
cdb.Promotions.AddRange(new List<Promotion>() { cdb001, cdb002 });

Eleve eleve5 = new Eleve() { Id = 5, Nom = "Dupond", Prenom = "fred", Promotion = cdb001 };
Eleve eleve6 = new Eleve() { Id = 6, Nom = "Durand", Prenom = "bob", Promotion = cdb001 };
cdb001.Eleves.AddRange(new List<Eleve>() { eleve5, eleve6 });

Eleve eleve7 = new Eleve() { Id = 7, Nom = "Liegois", Prenom = "chris", Promotion = cdb002 };
Eleve eleve8 = new Eleve() { Id = 8, Nom = "Becher", Prenom = "celine", Promotion = cdb002 };
cdb002.Eleves.AddRange(new List<Eleve>() { eleve7, eleve8 });

cda.Display();
cdb.Display();
