using System.Collections.Generic;
using System.Linq;
using StudyTrackingSys1.Data;
using StudyTrackingSys1.Models;

public class DafLineService : IDafLineService
{
    private readonly AppDbContext _context;

    public DafLineService(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<DafLine> GetAllDafLines()
    {
        return _context.DafLines.ToList();
    }

    public DafLine GetDafLineById(int id)
    {
        return _context.DafLines.FirstOrDefault(dl => dl.DafLineID == id);
    }

    public IEnumerable<DafLine> GetDafLinesByMasechetId(int masechetId)
    {
        return _context.DafLines.Where(dl => dl.MasechetID == masechetId).ToList();
    }

    public DafLine AddDafLine(DafLine dafLine)
    {
        _context.DafLines.Add(dafLine);
        _context.SaveChanges();
        return dafLine;
    }

    public void UpdateDafLine(DafLine dafLine)
    {
        _context.DafLines.Update(dafLine);
        _context.SaveChanges();
    }

    public void DeleteDafLine(int id)
    {
        var dafLine = _context.DafLines.FirstOrDefault(dl => dl.DafLineID == id);
        if (dafLine != null)
        {
            _context.DafLines.Remove(dafLine);
            _context.SaveChanges();
        }
    }
}
