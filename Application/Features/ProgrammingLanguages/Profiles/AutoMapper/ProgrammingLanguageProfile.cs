using Application.Features.Models;
using Application.Features.ProgrammingLanguages.Commands.CreateProgrammingLanguage;
using Application.Features.ProgrammingLanguages.Commands.DeleteProgrammingLanguage;
using Application.Features.ProgrammingLanguages.Dtos;
using AutoMapper;
using Core.Persistence.Paging;
using Domain;

namespace Application.Features.ProgrammingLanguages.Profiles.AutoMapper
{
    public class ProgrammingLanguageProfile : Profile
    {
        public ProgrammingLanguageProfile()
        {
            CreateMap<ProgrammingLanguage, CreateProgrammingLanguageDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, CreateProgrammingLanguageCommand>().ReverseMap();

            CreateMap<ProgrammingLanguage, ProgrammingLanguageListDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, ProgrammingLanguageListModel>().ReverseMap();
            CreateMap<ProgrammingLanguageListModel, IPaginate<ProgrammingLanguage>>().ReverseMap();

            CreateMap<ProgrammingLanguage, DeleteProgrammingLanguageCommand>().ReverseMap();
            CreateMap<ProgrammingLanguage, DeleteProgrammingLanguageDto>().ReverseMap();


        }
    }
}
