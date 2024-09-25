using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StudyTrackingSys1.Models;

[Route("api/[controller]")]
[ApiController]
public class StudyPlanController : ControllerBase
{
    private readonly IStudyPlanService _studyPlanService;

    public StudyPlanController(IStudyPlanService studyPlanService)
    {
        _studyPlanService = studyPlanService;
    }

    [HttpGet]
    public IEnumerable<StudyPlan> GetAllStudyPlans()
    {
        return _studyPlanService.GetAllStudyPlans();
    }

    [HttpGet("{id}")]
    public IActionResult GetStudyPlanById(int id)
    {
        var studyPlan = _studyPlanService.GetStudyPlanById(id);
        if (studyPlan == null)
            return NotFound();
        return Ok(studyPlan);
    }

    [HttpPost]
    public IActionResult AddStudyPlan(StudyPlan studyPlan)
    {
        var newStudyPlan = _studyPlanService.AddStudyPlan(studyPlan);
        return CreatedAtAction(nameof(GetStudyPlanById), new { id = newStudyPlan.PlanID }, newStudyPlan);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateStudyPlan(int id, StudyPlan studyPlan)
    {
        if (id != studyPlan.PlanID)
            return BadRequest();

        _studyPlanService.UpdateStudyPlan(studyPlan);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteStudyPlan(int id)
    {
        _studyPlanService.DeleteStudyPlan(id);
        return NoContent();
    }
}
