using StudyTrackingSys1.Models;

    namespace StudyTrackingSys1.Services
{
    public interface IMasechetService
    {
        IEnumerable<Masechet> GetAllMasechtot();
        Masechet GetMasechetById(int id);
        Masechet AddMasechet(Masechet masechet);
        void UpdateMasechet(Masechet masechet);
        void DeleteMasechetById(int id);
    }
}
