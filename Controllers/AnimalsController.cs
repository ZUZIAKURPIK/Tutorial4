using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;


[ApiController]
[Route("/animals-controller")]
public class AnimalsController : ControllerBase
{
    public static MockDb _db = new MockDb();
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = _db.Animals;
        return Ok(animals);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAnimalsById(int id)
    {
        var animal = _db.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
        {
            return NotFound();
        }
        return Ok(animal);
    }
    
    [HttpPost]
    public IActionResult AddAnimals(Animal animal)
    {
        _db.Animals.Add(animal);
        return CreatedAtAction(nameof(GetAnimalsById), new{id = animal.Id}, animal);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var existingAnimal = _db.Animals.FirstOrDefault(a => a.Id == id);
        if (existingAnimal == null)
        {
            return NotFound();
        }

        existingAnimal.Name = animal.Name;
        existingAnimal.Category = animal.Category;
        existingAnimal.Weight = animal.Weight;
        existingAnimal.FurColor = animal.FurColor;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DelateAnimal(int id)
    {
        var animal = _db.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
        {
            return NotFound();
        }

        _db.Animals.Remove(animal);
        return NoContent();
    }
}