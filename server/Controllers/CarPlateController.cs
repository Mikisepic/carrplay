using server.Models;
using server.Services;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers;

[ApiController]
[Route("[controller]")]
public class CarPlateController : ControllerBase
{
    public CarPlateController() { }

    [HttpGet]
    public ActionResult<List<CarPlate>> GetAll() => CarPlateService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<CarPlate> Get(Guid id)
    {
        var carPlate = CarPlateService.Get(id);

        if (carPlate == null)
            return NotFound();

        return carPlate;
    }

    [HttpPost]
    public IActionResult Create(CarPlate carPlate)
    {
        carPlate.Id = Guid.NewGuid();
        CarPlateService.Add(carPlate);
        return CreatedAtAction(nameof(Get), new { id = carPlate.Id }, carPlate);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, CarPlate carPlate)
    {
        if (id != carPlate.Id)
            return BadRequest();

        var existingCarPlate = CarPlateService.Get(id);
        if (existingCarPlate is null)
            return NotFound();

        CarPlateService.Update(carPlate);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var carPlate = CarPlateService.Get(id);
        if (carPlate is null)
            return NotFound();

        CarPlateService.Delete(id);

        return NoContent();
    }
}