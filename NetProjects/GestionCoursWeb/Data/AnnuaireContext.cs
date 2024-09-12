using System.Globalization;
using GestionCoursWeb.Models;

namespace GestionCoursWeb.Data;

internal class AnnuaireContext
{
    public List<Diplome> Diplomes { get; } = new List<Diplome>();
    public List<Promotion> Promotions { get; } = new List<Promotion>();
    public List<Eleve> Eleves { get; } = new List<Eleve>();

    public AnnuaireContext()
    {
        Diplome TSSR = new Diplome { /*Id = 1,*/ Code = "TSSR", Nom = "Technicien Supérieur Systèmes et Réseaux", Niveau = 5 };
        Diplome D2WM = new Diplome { /*Id = 2,*/ Code = "D2WM", Nom = "Développeur Web et Web Mobile", Niveau = 5 };
        Diplome ASR = new Diplome  { /*Id = 3,*/ Code = "ASR", Nom = "Administrateur Système et Réseau", Niveau = 6 };
        Diplome CDA = new Diplome  { /*Id = 4,*/ Code = "CDA", Nom = "Concepteur Développeur d'Applications", Niveau = 6 };
        Diplome ESD = new Diplome  { /*Id = 5,*/ Code = "ESD", Nom = "Expert en Sécurité Digitale", Niveau = 7 };
        Diplome MS2D = new Diplome { /*Id = 6,*/ Code = "MS2D", Nom = "Manager de Solutions Digitales et Data", Niveau = 7 };
        Diplomes.Add(TSSR);
        Diplomes.Add(D2WM);
        Diplomes.Add(ASR);
        Diplomes.Add(CDA);
        Diplomes.Add(ESD);
        Diplomes.Add(MS2D);

        Promotion NCDA_006 = new Promotion { Id = 1, Nom = "NCDA_006", Debut = DateTime.Parse("07/10/2019", new CultureInfo("fr-FR")), Fin = DateTime.Parse("27/08/2021", new CultureInfo("fr-FR")), Diplome = CDA };
        Promotion NCDA_007 = new Promotion { Id = 2, Nom = "NCDA_007", Debut = DateTime.Parse("12/10/2020", new CultureInfo("fr-FR")), Fin = DateTime.Parse("26/08/2022", new CultureInfo("fr-FR")), Diplome = CDA };
        Promotion NCDA_008 = new Promotion { Id = 3, Nom = "NCDA_008", Debut = DateTime.Parse("11/10/2021", new CultureInfo("fr-FR")), Fin = DateTime.Parse("14/07/2023", new CultureInfo("fr-FR")), Diplome = CDA };
        Promotion NASR_008 = new Promotion { Id = 4, Nom = "NASR_008", Debut = DateTime.Parse("11/10/2021", new CultureInfo("fr-FR")), Fin = DateTime.Parse("14/07/2023", new CultureInfo("fr-FR")), Diplome = ASR };
        Promotion MS2D_001 = new Promotion { Id = 5, Nom = "MS2D_001", Debut = DateTime.Parse("11/10/2021", new CultureInfo("fr-FR")), Fin = DateTime.Parse("15/10/2022", new CultureInfo("fr-FR")), Diplome = MS2D };
        Promotion NESD_001 = new Promotion { Id = 6, Nom = "NESD_001", Debut = DateTime.Parse("04/10/2021", new CultureInfo("fr-FR")), Fin = DateTime.Parse("07/10/2022", new CultureInfo("fr-FR")), Diplome = ESD };
        Promotions.Add(NCDA_006);
        Promotions.Add(NCDA_007);
        Promotions.Add(NCDA_008);
        Promotions.Add(NASR_008);
        Promotions.Add(MS2D_001);
        Promotions.Add(NESD_001);
        ASR.Promotions.AddRange(Promotions.Where(p => p.Diplome.Equals(ASR)).ToList());
        CDA.Promotions.AddRange(Promotions.Where(p => p.Diplome.Equals(CDA)).ToList());
        ESD.Promotions.AddRange(Promotions.Where(p => p.Diplome.Equals(ESD)).ToList());
        MS2D.Promotions.AddRange(Promotions.Where(p => p.Diplome.Equals(MS2D)).ToList());

        Eleve AMARTIN = new Eleve { Id = 1, Nom = "MARTIN", Prenom = "Alexis", Adresse = "19 avenue Léo Lagrange", CodePostal = "79000", Ville = "Niort", Promotion = NCDA_007 };
        Eleve CDUPONT = new Eleve { Id = 2, Nom = "DUPONT", Prenom = "Claire", Adresse = "2 avenue de Limoges", CodePostal = "79000", Ville = "Niort", Promotion = NCDA_007 };
        Eleve AAUBIN = new Eleve { Id = 3, Nom = "AUBIN", Prenom = "Adèle", Adresse = "6 rue Alphonse Farault", CodePostal = "79000", Ville = "Niort", Promotion = NCDA_008 };
        Eleve GCOLLIN = new Eleve { Id = 4, Nom = "COLLIN", Prenom = "Grégoire", Adresse = "18 rue de l'Hôtel de ville", CodePostal = "79180", Ville = "Chauray", Promotion = NCDA_008 };
        Eleve IBOISVERT = new Eleve { Id = 5, Nom = "BOISVERT", Prenom = "Isabelle", Adresse = "352 avenue de La Rochelle", CodePostal = "79000", Ville = "Niort", Promotion = NCDA_008 };
        Eleve YMIRON = new Eleve { Id = 6, Nom = "MIRON", Prenom = "Yvan", Adresse = "6 rue de la ferme", CodePostal = "79450", Ville = "Saint-Aubin-le-Cloud", Promotion = NESD_001 };
        Eleve MLETOURNEAU = new Eleve { Id = 7, Nom = "LETOURNEAU", Prenom = "Margaux", Adresse = "12 rue de l'ancienne Poudrière", CodePostal = "79000", Ville = "Bessines", Promotion = MS2D_001 };
        NCDA_007.Eleves.Add(AMARTIN);
        NCDA_007.Eleves.Add(CDUPONT);
        NCDA_008.Eleves.Add(AAUBIN);
        NCDA_008.Eleves.Add(GCOLLIN);
        NCDA_008.Eleves.Add(IBOISVERT);
        NESD_001.Eleves.Add(YMIRON);
        MS2D_001.Eleves.Add(MLETOURNEAU);

        Eleves.Add(AMARTIN);
        Eleves.Add(CDUPONT);
        Eleves.Add(AAUBIN);
        Eleves.Add(GCOLLIN);
        Eleves.Add(IBOISVERT);
        Eleves.Add(YMIRON);
        Eleves.Add(MLETOURNEAU);
    }
}
