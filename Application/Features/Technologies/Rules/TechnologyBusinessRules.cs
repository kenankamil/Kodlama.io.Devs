using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Domain;

namespace Application.Features.Technologies.Rules
{
    public class TechnologyBusinessRules
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

        public TechnologyBusinessRules(IProgrammingLanguageRepository programmingLanguageRepository)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
        }

        public async Task ProgramminLanguageShouldBeExist(int id)
        {
            ProgrammingLanguage result = await _programmingLanguageRepository.GetAsync(p => p.Id == id);
            if (result == null) throw new BusinessException("Language id does not exist.");
        }

    }
}
