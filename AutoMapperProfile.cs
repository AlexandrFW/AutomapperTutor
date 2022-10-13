using AutoMapper;

namespace AutomapperTutor;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<SuperHero, SuperHeroDTO>();
        CreateMap<SuperHeroDTO, SuperHero>();
    }
}
