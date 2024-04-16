using server.Models;

namespace server.Services;

public static class CarPlateService
{
    static List<CarPlate> CarPlates { get; }
    static CarPlateService()
    {
        CarPlates = new List<CarPlate> {
            new CarPlate {Id = Guid.NewGuid(), Plate = "QWE-123"},
            new CarPlate {Id = Guid.NewGuid(), Plate = "ABC-124"},
        };
    }

    public static List<CarPlate> GetAll() => CarPlates;

    public static CarPlate? Get(Guid id) => CarPlates.FirstOrDefault(carPlate => carPlate.Id == id);

    public static void Add(CarPlate carPlate)
    {
        carPlate.Id = Guid.NewGuid();
        CarPlates.Add(carPlate);
    }

    public static void Delete(Guid id)
    {
        var carPlate = Get(id);
        if (carPlate is null)
            return;

        CarPlates.Remove(carPlate);
    }

    public static void Update(CarPlate carPlate)
    {
        var index = CarPlates.FindIndex(plate => carPlate.Id == plate.Id);
        if (index == -1)
            return;

        CarPlates[index] = carPlate;
    }
}