using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StudyTrackingSys1.Models;

[Route("api/[controller]")]
[ApiController]
public class DafLineController : ControllerBase
{
    private readonly IDafLineService _dafLineService;

    public DafLineController(IDafLineService dafLineService)
    {
        _dafLineService = dafLineService;
    }

    [HttpGet]
    public IEnumerable<DafLine> GetAllDafLines()
    {
        return _dafLineService.GetAllDafLines();
    }

    [HttpGet("{id}")]
    public IActionResult GetDafLineById(int id)
    {
        var dafLine = _dafLineService.GetDafLineById(id);
        if (dafLine == null)
            return NotFound();
        return Ok(dafLine);
    }

    [HttpPost]
    public IActionResult AddDafLine(DafLine dafLine)
    {
        var newDafLine = _dafLineService.AddDafLine(dafLine);
        return CreatedAtAction(nameof(GetDafLineById), new { id = newDafLine.DafLineID }, newDafLine);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateDafLine(int id, DafLine dafLine)
    {
        if (id != dafLine.DafLineID)
            return BadRequest();

        _dafLineService.UpdateDafLine(dafLine);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteDafLine(int id)
    {
        _dafLineService.DeleteDafLine(id);
        return NoContent();
    }
}
