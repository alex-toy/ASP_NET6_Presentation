using Microsoft.AspNetCore.Mvc;

namespace CoursAPI.Controllers;

/// <summary>
/// controlleur de test
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    /// <summary>
    /// Saluer l'utilisateur en mentionnant son nom
    /// </summary>
    /// <param name="nom">Nom de l'utilisateur</param>
    /// <returns>salutation suivi du nom de la personne</returns>
    [HttpGet("bonjour/{nom}")]
    public IActionResult Get(string nom)
    {
        if (string.IsNullOrEmpty(nom)) return BadRequest();

        return Ok($"bonjour {nom}");
    }
}
