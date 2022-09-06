using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Domain;

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
            if (result != null) throw new BusinessException("Language name exist.");
        }

        public async Task ProgrammingLanguageShouldExist(int id)
        {
            ProgrammingLanguage result = await _programmingLanguageRepository.GetAsync(p => p.Id == id);
            if (result == null) throw new BusinessException("Language does not exist.");
        }
    }
}
