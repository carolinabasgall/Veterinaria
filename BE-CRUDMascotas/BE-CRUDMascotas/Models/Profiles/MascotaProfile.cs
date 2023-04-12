using AutoMapper;
using BE_CRUDMascotas.Models.DTO;

namespace BE_CRUDMascotas.Models.Profiles
{
  public class MascotaProfile : Profile
  {
    public MascotaProfile()
    {
      CreateMap<mascota, MascotaDTO>();
      CreateMap<MascotaDTO, mascota>();
    }
  }

}

