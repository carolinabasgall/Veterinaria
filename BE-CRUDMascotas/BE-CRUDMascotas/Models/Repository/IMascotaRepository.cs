namespace BE_CRUDMascotas.Models.Repository
{
  public interface IMascotaRepository
  {
    Task<List<mascota>> GetListMascotas();
    Task<mascota> GetMascota(int id);
    Task DeleteMascota(mascota mascota);
    Task<mascota> AddMascota(mascota mascota);
    Task UpdateMascota(mascota mascota);

  }
}
