using Application.Features.ProgrammingLanguages.Dtos;
using Application.Features.ProgrammingLanguages.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProgrammingLanguages.Commands.DeleteProgrammingLanguage
{
    public class DeleteProgrammingLanguageCommand : IRequest<DeleteProgrammingLanguageDto>
    {
        public int Id { get; set; }
        //public string Name { get; set; }

        public class DeleteProgrammingLanguageCommandHandler : IRequestHandler<DeleteProgrammingLanguageCommand, DeleteProgrammingLanguageDto>
        {
            private readonly IMapper _mapper;
            private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
            private readonly ProgrammingLanguageBusinessRules _programmingLanguageBusinessRules;

            public DeleteProgrammingLanguageCommandHandler(IMapper mapper, IProgrammingLanguageRepository programmingLanguageRepository, ProgrammingLanguageBusinessRules programmingLanguageBusinessRules)
            {
                _mapper = mapper;
                _programmingLanguageRepository = programmingLanguageRepository;
                _programmingLanguageBusinessRules = programmingLanguageBusinessRules;
            }

            public async Task<DeleteProgrammingLanguageDto> Handle(DeleteProgrammingLanguageCommand request, CancellationToken cancellationToken)
            {
                await _programmingLanguageBusinessRules.ProgrammingLanguageShouldExist(request.Id);

                ProgrammingLanguage programmingLanguage = await _programmingLanguageRepository.GetAsync(p => p.Id == request.Id);
                ProgrammingLanguage result = await _programmingLanguageRepository.DeleteAsync(programmingLanguage);

                var deletedProgrammingLanguage = _mapper.Map<DeleteProgrammingLanguageDto>(result);

                return deletedProgrammingLanguage;
            }
        }
    }
}
