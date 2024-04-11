using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;

[ApiController]
[Route("/visits")]
public class VisitsController : ControllerBase
{
    private static MockDb _db = AnimalsController._db;
    
    [HttpGet("{animalId}")]
    public IActionResult GetVisitsForAnimal(int animalId)
    {
        var visits = _db.Visits.Where(v => v.AnimalId == animalId).ToList();
        return Ok(visits);
    }

    [HttpPost]
    public IActionResult AddVisit(Visit visit)
    {
        _db.Visits.Add(visit);
        return CreatedAtAction(nameof(GetVisitsForAnimal), new { animalId = visit.AnimalId }, visit);
    }
}