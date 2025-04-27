namespace APBD_cw4.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Category { get; set; } = null!;
    public float Weight { get; set; }
    public string FurColor { get; set; } = null!;
}