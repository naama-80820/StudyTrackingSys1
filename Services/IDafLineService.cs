using System.Collections.Generic;
using StudyTrackingSys1.Models;

public interface IDafLineService
{
    IEnumerable<DafLine> GetAllDafLines();
    DafLine GetDafLineById(int id);
    IEnumerable<DafLine> GetDafLinesByMasechetId(int masechetId);
    DafLine AddDafLine(DafLine dafLine);
    void UpdateDafLine(DafLine dafLine);
    void DeleteDafLine(int id);
}
