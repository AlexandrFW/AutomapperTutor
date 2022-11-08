using AutoMapper;
using AutomapperTutor.Model.DTO;
using AutomapperTutor.Model.Statistics;

namespace AutomapperTutor;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<SuperHero, SuperHeroDTO>();
        CreateMap<SuperHeroDTO, SuperHero>();

        CreateMap<(Statistics statistic, Machine machine, Product product), IndividualWeightDTO>()
            .ForMember(s => s.CurrentWeight, m => m.MapFrom(source => source.statistic.CurrentWeight))
            .ForMember(s => s.IPAddress, m => m.MapFrom(source => source.machine.IPAddress))
            .ForMember(s => s.ProdCode, m => m.MapFrom(source => source.product.ProdCode));
    }
}
