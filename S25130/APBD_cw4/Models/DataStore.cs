using APBD_cw4.Models;

namespace APBD_cw4.Models;

public class DataStore
{
    public static List<Animal> Animals { get; set; } = new()
    {
        new Animal { Id = 1, Name = "Reksio", Category = "Pies", Weight = 10.5f, FurColor = "Brązowy" },
        new Animal { Id = 2, Name = "Mruczek", Category = "Kot", Weight = 4.2f, FurColor = "Czarny" }
    };

    public static List<Visit> Visits { get; set; } = new()
    {
        new Visit { Id = 1, AnimalId = 1, Date = DateTime.Now.AddDays(-10), Description = "Szczepienie", Price = 150 },
        new Visit { Id = 2, AnimalId = 2, Date = DateTime.Now.AddDays(-5), Description = "Odrobaczanie", Price = 100 }
    };

}