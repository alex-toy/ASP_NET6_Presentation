using GestionCoursWeb.Data;
using GestionCoursWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionCoursWeb.Controllers;

public class AnnuaireController : Controller
{
    private readonly AnnuaireContext _context = new AnnuaireContext();

    public IActionResult Index()
    {
        List<Diplome> diplomes = _context.Diplomes
            .OrderBy(d => d.Niveau)
            .ThenBy(d => d.Nom)
            .ToList();

        return View(diplomes);
    }

    public IActionResult Edit(int id)
    {
        Diplome? diplome = _context.Diplomes.FirstOrDefault(d => d.Id == id);

        if (diplome is null) return NotFound();

        return View(diplome);
    }

    [HttpPost]
    public IActionResult Edit(Diplome diplome)
    {
        Diplome? diplomeDb = _context.Diplomes.FirstOrDefault(d => d.Id == diplome.Id);

        if (diplomeDb is null) return NotFound();

        diplomeDb.Code = diplome.Code;
        diplomeDb.Niveau = diplome.Niveau;
        diplomeDb.Nom = diplome.Nom;

        return RedirectToAction("Index");
    }
}
