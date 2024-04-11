using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;

namespace Tutorial4.Controllers;


[ApiController]
[Route("/animals-controller")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().animals;
        return Ok(animals);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAnimalsById(int id)
    {
        return Ok(id);
    }
    
    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Created();
    }
    
    
    
    // drugi sposób robienia końcówke ale nie daje to działania w aplikacji
}