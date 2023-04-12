using Microsoft.EntityFrameworkCore;

namespace BE_CRUDMascotas.Models.Repository
{
  public class MascotaRepository: IMascotaRepository
  {
    private readonly AplicationDbContext _context;

    public MascotaRepository(AplicationDbContext context)
    {
      _context = context;
    }

    public async Task<mascota> AddMascota(mascota mascota)
    {
      _context.Add(mascota);
      await _context.SaveChangesAsync();
      return mascota;
    }

    public async Task DeleteMascota(mascota mascota)
    {
      _context.Mascotas.Remove(mascota);
      await _context.SaveChangesAsync();
    }

    public async Task<List<mascota>> GetListMascotas()
    {
     return  await _context.Mascotas.ToListAsync();
    }

    public async Task<mascota> GetMascota(int id)
    {
      return await _context.Mascotas.FindAsync(id);
    }

    public async Task UpdateMascota(mascota mascota)
    {
      var mascotaItem = await _context.Mascotas.FirstOrDefaultAsync(x => x.Id == mascota.Id);

      if (mascotaItem != null)
      {
        mascotaItem.Nombre = mascota.Nombre;
        mascotaItem.Raza = mascota.Raza;
        mascotaItem.Edad = mascota.Edad;
        mascotaItem.Peso = mascota.Peso;
        mascotaItem.Color = mascota.Color;

        await _context.SaveChangesAsync();
      }
     
    }
  }
}
