using System.Collections.Generic;
using StudyTrackingSys1.Models;

public interface IStudyProgressService
{
    IEnumerable<StudyProgress> GetAllStudyProgress();
    IEnumerable<StudyProgress> GetStudyProgressByPlanId(int planId);
    StudyProgress AddStudyProgress(StudyProgress studyProgress);
    void UpdateStudyProgress(StudyProgress studyProgress);
    void DeleteStudyProgress(int id);
}
