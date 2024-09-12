using GestionCoursWeb.Data;
using GestionCoursWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionCoursWeb.Controllers;

public class AnnuaireController : Controller
{
    private readonly DatabaseContext _context;

    public AnnuaireController(DatabaseContext context)
    {
        _context = context;
    }

    private readonly AnnuaireContext _annuaireContext = new AnnuaireContext();

    public async Task<IActionResult> Index()
    {

        //List<Diplome> diplomes = _annuaireContext.Diplomes.ToList();
        //diplomes.ForEach(n => _context.Add(n));
        //await _context.SaveChangesAsync();

        List<Diplome> diplomes = _context.Diplomes.ToList();

        return View(diplomes);
    }

    public IActionResult Edit(int id)
    {
        Diplome? diplome = _context.Diplomes.FirstOrDefault(d => d.Id == id);

        if (diplome is null) return NotFound();

        return View(diplome);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Diplome diplome)
    {
        Diplome? diplomeDb = _context.Diplomes.FirstOrDefault(d => d.Id == diplome.Id);

        if (diplomeDb is null) return NotFound();

        diplomeDb.Code = diplome.Code;
        diplomeDb.Niveau = diplome.Niveau;
        diplomeDb.Nom = diplome.Nom;
        //_context.Add(diplome);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Diplome diplome)
    {
        _context.Add(diplome);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }
}
