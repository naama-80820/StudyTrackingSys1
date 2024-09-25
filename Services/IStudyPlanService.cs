using System.Collections.Generic;
using StudyTrackingSys1.Models;

public interface IStudyPlanService
{
    IEnumerable<StudyPlan> GetAllStudyPlans();
    StudyPlan GetStudyPlanById(int id);
    IEnumerable<StudyPlan> GetStudyPlansByUserId(int userId);
    StudyPlan AddStudyPlan(StudyPlan studyPlan);
    void UpdateStudyPlan(StudyPlan studyPlan);
    void DeleteStudyPlan(int id);
}
