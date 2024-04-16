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
}