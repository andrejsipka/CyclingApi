using CyclingApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace CyclingApi.Controllers;

[Route("api/activities")]
[ApiController]
public class ActivitiesController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    
    public ActivitiesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var activities = _context.Activities.ToList();
        
        return Ok(activities);
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var activity = _context.Activities.Find(id);

        if (activity == null)
        {
            return NotFound();
        }

        return Ok(activity);
    }
}