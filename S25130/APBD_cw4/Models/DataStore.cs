using APBD_cw4.Models;

namespace APBD_cw4.Models;

public class DataStore
{
    public static List<Animal> Animals { get; set; } = new()
    {
        new Animal { Id = 1, Name = "Reksio", Category = "Pies", Weight = 10.3f, FurColor = "Brązowo-biały" },
        new Animal { Id = 2, Name = "Puszek", Category = "Kot", Weight = 4.6f, FurColor = "Biały" }
    };

    public static List<Visit> Visits { get; set; } = new()
    {
        new Visit { Id = 1, AnimalId = 1, Date = DateTime.Now.AddDays(-10), Description = "Szczepienie", Price = 195 },
        new Visit { Id = 2, AnimalId = 2, Date = DateTime.Now.AddDays(-5), Description = "Odrobaczanie", Price = 100 },
        new Visit { Id = 3, AnimalId = 2, Date = DateTime.Now.AddDays(-15), Description = "Kastracja", Price = 555 },
        new Visit { Id = 4, AnimalId = 1, Date = DateTime.Now.AddDays(-29), Description = "Usuwanie kamienia nazębnego", Price = 1475 }
    };

}