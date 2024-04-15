namespace server.Models;

public class User
{
    public Guid Id { get; set; }
    public required string Username { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public List<CarPlate>? CarPlates { get; set; }
}