using Microsoft.AspNetCore.Mvc;
using APBD_cw4.Models;

namespace APBD_cw4.Controllers;

[ApiController]
[Route("api/animals/{animalId}/visits")]
public class VisitsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetVisitsForAnimal(int animalId)
    {
        var visits = DataStore.Visits.Where(v => v.AnimalId == animalId).ToList();
        return Ok(visits);
    }

    [HttpPost]
    public IActionResult AddVisit(int animalId, Visit visit)
    {
        if (!DataStore.Animals.Any(a => a.Id == animalId))
            return NotFound("Zwierzę nie istnieje");

        visit.Id = DataStore.Visits.Max(v => v.Id) + 1;
        visit.AnimalId = animalId;
        DataStore.Visits.Add(visit);
        return CreatedAtAction(nameof(GetVisitsForAnimal), new { animalId }, visit);
    }
}