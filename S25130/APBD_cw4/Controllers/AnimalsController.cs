using Microsoft.AspNetCore.Mvc;
using APBD_cw4.Models;

namespace APBD_cw4.Controllers;

[ApiController]
[Route("api/animals")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll() => Ok(DataStore.Animals);

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var animal = DataStore.Animals.FirstOrDefault(a => a.Id == id);
        return animal is null ? NotFound() : Ok(animal);
    }

    [HttpGet("search")]
    public IActionResult SearchByName([FromQuery] string name)
    {
        var results = DataStore.Animals.Where(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
        return Ok(results);
    }

    [HttpPost]
    public IActionResult Create(Animal animal)
    {
        animal.Id = DataStore.Animals.Max(a => a.Id) + 1;
        DataStore.Animals.Add(animal);
        return CreatedAtAction(nameof(GetById), new { id = animal.Id }, animal);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Animal updated)
    {
        var animal = DataStore.Animals.FirstOrDefault(a => a.Id == id);
        if (animal is null) return NotFound();
        animal.Name = updated.Name;
        animal.Category = updated.Category;
        animal.Weight = updated.Weight;
        animal.FurColor = updated.FurColor;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var animal = DataStore.Animals.FirstOrDefault(a => a.Id == id);
        if (animal is null) return NotFound();
        DataStore.Animals.Remove(animal);
        return NoContent();
    }
}