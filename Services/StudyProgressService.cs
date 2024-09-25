using System.Collections.Generic;
using System.Linq;
using StudyTrackingSys1.Data;
using StudyTrackingSys1.Models;

public class StudyProgressService : IStudyProgressService
{
    private readonly AppDbContext _context;

    public StudyProgressService(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<StudyProgress> GetAllStudyProgress()
    {
        return _context.StudyProgress.ToList();
    }

    public IEnumerable<StudyProgress> GetStudyProgressByPlanId(int planId)
    {
        return _context.StudyProgress.Where(sp => sp.PlanID == planId).ToList();
    }

    public StudyProgress AddStudyProgress(StudyProgress studyProgress)
    {
        _context.StudyProgress.Add(studyProgress);
        _context.SaveChanges();
        return studyProgress;
    }

    public void UpdateStudyProgress(StudyProgress studyProgress)
    {
        _context.StudyProgress.Update(studyProgress);
        _context.SaveChanges();
    }

    public void DeleteStudyProgress(int id)
    {
        var studyProgress = _context.StudyProgress.FirstOrDefault(sp => sp.ProgressID == id);
        if (studyProgress != null)
        {
            _context.StudyProgress.Remove(studyProgress);
            _context.SaveChanges();
        }
    }
}
