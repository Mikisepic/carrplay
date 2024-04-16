using server.Models;

namespace server.Services;

public static class UserService
{
    static List<User> Users { get; }

    static UserService()
    {
        Users = new List<User> {
            new User {Id = Guid.NewGuid(), FirstName = "John", LastName = "Doe", Username = "jdoe", CarPlates = []},
        };
    }

    public static List<User> GetAll() => Users;

    public static User? Get(Guid id) => Users.FirstOrDefault(user => user.Id == id);

    public static List<CarPlate>? GetUserCarPlates(Guid id)
    {
        var user = Get(id);

        if (user is null)
            return [];

        return user.CarPlates;
    }

    public static void Add(User user)
    {
        user.Id = Guid.NewGuid();
        Users.Add(user);
    }

    public static void Delete(Guid id)
    {
        var user = Get(id);
        if (user is null)
            return;

        Users.Remove(user);
    }

    public static void Update(User user)
    {
        var index = Users.FindIndex(plate => user.Id == plate.Id);
        if (index == -1)
            return;

        Users[index] = user;
    }
}