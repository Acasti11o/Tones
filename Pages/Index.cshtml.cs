using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tones.Models;


namespace Tones.Pages;

public class IndexModel : PageModel
{
    private readonly ToneDbContext _context;
    private readonly ILogger<IndexModel> _logger;
    public List<Tone>Tones{get;set;} = default!;

    public IndexModel(ToneDbContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        Tones = _context.Tones.ToList();
    }
}
