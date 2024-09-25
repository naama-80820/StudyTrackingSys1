using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StudyTrackingSys1.Models;

[Route("api/[controller]")]
[ApiController]
public class StudyProgressController : ControllerBase
{
    private readonly IStudyProgressService _studyProgressService;

    public StudyProgressController(IStudyProgressService studyProgressService)
    {
        _studyProgressService = studyProgressService;
    }

    [HttpGet]
    public IEnumerable<StudyProgress> GetAllStudyProgress()
    {
        return _studyProgressService.GetAllStudyProgress();
    }

    [HttpGet("{planId}")]
    public IEnumerable<StudyProgress> GetStudyProgressByPlanId(int planId)
    {
        return _studyProgressService.GetStudyProgressByPlanId(planId);
    }

    [HttpPost]
    public IActionResult AddStudyProgress(StudyProgress studyProgress)
    {
        var newProgress = _studyProgressService.AddStudyProgress(studyProgress);
        return CreatedAtAction(nameof(GetStudyProgressByPlanId), new { planId = newProgress.PlanID }, newProgress);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateStudyProgress(int id, StudyProgress studyProgress)
    {
        if (id != studyProgress.ProgressID)
            return BadRequest();

        _studyProgressService.UpdateStudyProgress(studyProgress);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteStudyProgress(int id)
    {
        _studyProgressService.DeleteStudyProgress(id);
        return NoContent();
    }
}
