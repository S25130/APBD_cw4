namespace APBD_cw4.Models;

public class Visit
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int AnimalId { get; set; }
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
}