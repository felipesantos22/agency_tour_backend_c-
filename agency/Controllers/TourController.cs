using agency.Models;
using agency.Repository;
using Microsoft.AspNetCore.Mvc;

namespace agency.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TourController : ControllerBase
{
    private readonly TourRepository _tourRepository;

    public TourController(TourRepository tourRepository)
    {
        this._tourRepository = tourRepository;
    }


    [HttpPost]
    public async Task<ActionResult<Tour>> Create([FromBody] Tour tour)
    {
        var newTeam = await _tourRepository.Create(tour);
        return Ok(newTeam);
    }

    [HttpGet]
    public async Task<ActionResult<List<Tour>>> Index()
    {
        var tours = await _tourRepository.Index();
        return Ok(tours);
    }
}