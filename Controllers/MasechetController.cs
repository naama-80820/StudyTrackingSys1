using Microsoft.AspNetCore.Mvc;
using StudyTrackingSys1.Models;
using StudyTrackingSys1.Services;


[Route("api/[controller]")]
[ApiController]
public class MasechetController : ControllerBase
{
    private readonly IMasechetService _masechetService;

    public MasechetController(IMasechetService masechetService)
    {
        _masechetService = masechetService;
    }

    [HttpGet]
    public IActionResult GetAllMasechtot()
    {
        return Ok(_masechetService.GetAllMasechtot());
    }

    [HttpGet("{id}")]
    public IActionResult GetMasechetById(int id)
    {
        var masechet = _masechetService.GetMasechetById(id);
        if (masechet == null)
            return NotFound();
        return Ok(masechet);
    }

    [HttpPost]
    public IActionResult AddMasechet(Masechet masechet)
    {
        var newMasechet = _masechetService.AddMasechet(masechet);
        return CreatedAtAction(nameof(GetMasechetById), new { id = newMasechet.MasechetID }, newMasechet);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateMasechet(int id, Masechet masechet)
    {
        if (id != masechet.MasechetID)
            return BadRequest();

        _masechetService.UpdateMasechet(masechet);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteMasechet(int id)
    {
        _masechetService.DeleteMasechetById(id);
        return NoContent();
    }
}
