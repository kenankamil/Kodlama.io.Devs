using Application.Features.Technologies.Commands.CreateTechnology;
using Application.Features.Technologies.Dtos;
using Application.Features.Technologies.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain;

namespace Application.Features.Technologies.Profiles.AutoMapper
{
    public class TechnologyProfile : Profile
    {
        public TechnologyProfile()
        {
            CreateMap<Technology, CreateTechnologyDto>().ReverseMap();
            CreateMap<Technology, CreateTechnologyCommand>().ReverseMap();

            CreateMap<Technology, TechnologyListDto>()
                .ForMember(t => t.ProgrammingLanguageName, opt => opt.MapFrom(c => c.ProgrammingLanguage.Name))
                .ReverseMap();
            CreateMap<Technology, TechnologyListModel>().ReverseMap();
            CreateMap<TechnologyListModel, IPaginate<Technology>>().ReverseMap();

            //CreateMap<Technology, DeleteProgrammingLanguageCommand>().ReverseMap();
            //CreateMap<Technology, DeleteProgrammingLanguageDto>().ReverseMap();

            //CreateMap<Technology, UpdateProgrammingLanguageCommand>().ReverseMap();
            //CreateMap<Technology, UpdateProgrammingLanguageDto>().ReverseMap();

        }
    }
}
