namespace server.Models;

public class CarPlate
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string? Plate { get; set; }
}