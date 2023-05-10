using Microsoft.EntityFrameworkCore;
namespace Tones.Models
{
	public class ToneDbContext : DbContext
	{
		public ToneDbContext (DbContextOptions<ToneDbContext> options)
			: base(options)
		{
		}
		public DbSet<Tone> Tones {get; set;} = default!;
	}
}