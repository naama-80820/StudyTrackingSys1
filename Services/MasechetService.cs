using System.Collections.Generic;
using System.Linq;
using StudyTrackingSys1.Models;
using Microsoft.EntityFrameworkCore;
using StudyTrackingSys1.Services;
using StudyTrackingSys1.Data;


public class MasechetService : IMasechetService
{
    private readonly AppDbContext _context;

    public MasechetService(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Masechet> GetAllMasechtot()
    {
        return _context.Masechtot.ToList();
    }

    public Masechet GetMasechetById(int id)
    {
        return _context.Masechtot.FirstOrDefault(m => m.MasechetID == id);
    }

    public Masechet AddMasechet(Masechet masechet)
    {
        _context.Masechtot.Add(masechet);
        _context.SaveChanges();
        return masechet;
    }

    public void UpdateMasechet(Masechet masechet)
    {
        var existingMasechet = _context.Masechtot.FirstOrDefault(m => m.MasechetID == masechet.MasechetID);
        if (existingMasechet != null)
        {
            existingMasechet.MasechetName = masechet.MasechetName;
            existingMasechet.SederName = masechet.SederName;
            _context.SaveChanges();
        }
    }

    public void DeleteMasechetById(int id)
    {
        var masechet = _context.Masechtot.FirstOrDefault(m => m.MasechetID == id);
        if (masechet != null)
        {
            _context.Masechtot.Remove(masechet);
            _context.SaveChanges();
        }
    }
}
