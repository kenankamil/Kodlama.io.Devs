using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProgrammingLanguages.Rules
{
    public class ProgrammingLanguageBusinessRules
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

        public ProgrammingLanguageBusinessRules(IProgrammingLanguageRepository programmingLanguageRepository)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
        }

        public async Task ProgrammingLanguageNameCanNotDublicatedWhenInsertedAsync(string name)
        {
            ProgrammingLanguage result = await _programmingLanguageRepository.GetAsync(p => p.Name == name);
            if (result == null) throw new BusinessException("Language name exist.");
        }
    }
}
