namespace client.Models;

public class Plate
{
    public Guid Id { get; set; }
    public string PlateString { get; set; } = "";
    public DateTime CreatedAt { get; set; }
    public string Country { get; set; } = "";
    public string GetFormattedLicense() => $"{Country}-{PlateString}";
}