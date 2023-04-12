
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BE_CRUDMascotas.Models
{
  public class AplicationDbContext: DbContext
  {
    public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base (options)
    {
    
    }
    public DbSet<mascota> Mascotas { get; set; }
  }

}
