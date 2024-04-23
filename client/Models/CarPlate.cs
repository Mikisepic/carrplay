using System.ComponentModel.DataAnnotations;

namespace client.Models;

public class CarPlate
{
    public Guid Id { get; set; }
    public string PlateString { get; set; } = "";
    public DateTime CreatedAt { get; set; }
    public string Country { get; set; } = "";
}