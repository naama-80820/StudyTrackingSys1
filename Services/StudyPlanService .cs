using System.Collections.Generic;
using System.Linq;
using StudyTrackingSys1.Data;
using StudyTrackingSys1.Models;

public class StudyPlanService : IStudyPlanService
{
    private readonly AppDbContext _context;

    public StudyPlanService(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<StudyPlan> GetAllStudyPlans()
    {
        return _context.StudyPlans.ToList();
    }

    public StudyPlan GetStudyPlanById(int id)
    {
        return _context.StudyPlans.FirstOrDefault(sp => sp.PlanID == id);
    }

    public IEnumerable<StudyPlan> GetStudyPlansByUserId(int userId)
    {
        return _context.StudyPlans.Where(sp => sp.UserID == userId).ToList();
    }

    public StudyPlan AddStudyPlan(StudyPlan studyPlan)
    {
        _context.StudyPlans.Add(studyPlan);
        _context.SaveChanges();
        return studyPlan;
    }

    public void UpdateStudyPlan(StudyPlan studyPlan)
    {
        _context.StudyPlans.Update(studyPlan);
        _context.SaveChanges();
    }

    public void DeleteStudyPlan(int id)
    {
        var studyPlan = _context.StudyPlans.FirstOrDefault(sp => sp.PlanID == id);
        if (studyPlan != null)
        {
            _context.StudyPlans.Remove(studyPlan);
            _context.SaveChanges();
        }
    }
}
