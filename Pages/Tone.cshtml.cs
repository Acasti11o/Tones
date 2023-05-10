using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tones.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Tones.Pages;

public class TonesModel : ToneModel
{
    private readonly ToneDbContext _context;
    private readonly ILogger<TonesModel> _logger;
    public List<Tone> Artists {get; set;} = default!;
    public SelectList ArtistDropDown {get; set;} = default!;
    [BindProperty]
    public Tone Tone {get; set;} = default!;

    public TonesModel(ToneDbContext context, ILogger<TonesModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        Tone = _context.Tones.ToList();
        ArtistDropDown = new SelectList(Artists, "ToneId", "FirstName");
    }

    public void OnPost()
    {
        Tone = _context.Tones.Find(Tone.ToneId)!;
        Tone = _context.Tones.ToList();
        ArtistDropDown = new SelectList(Artists, "ToneId", "FirstName");
    }
}