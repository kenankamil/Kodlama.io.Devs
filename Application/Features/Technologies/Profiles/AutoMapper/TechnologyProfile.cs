using Application.Features.Technologies.Commands.CreateTechnology;
using Application.Features.Technologies.Dtos;
using AutoMapper;
using Domain;

namespace Application.Features.Technologies.Profiles.AutoMapper
{
    public class TechnologyProfile : Profile
    {
        public TechnologyProfile()
        {
            CreateMap<Technology, CreateTechnologyDto>().ReverseMap();
            CreateMap<Technology, CreateTechnologyCommand>().ReverseMap();

            //CreateMap<Technology, ProgrammingLanguageListDto>().ReverseMap();
            //CreateMap<Technology, ProgrammingLanguageListModel>().ReverseMap();
            //CreateMap<ProgrammingLanguageListModel, IPaginate<ProgrammingLanguage>>().ReverseMap();

            //CreateMap<Technology, DeleteProgrammingLanguageCommand>().ReverseMap();
            //CreateMap<Technology, DeleteProgrammingLanguageDto>().ReverseMap();

            //CreateMap<Technology, UpdateProgrammingLanguageCommand>().ReverseMap();
            //CreateMap<Technology, UpdateProgrammingLanguageDto>().ReverseMap();

        }
    }
}
