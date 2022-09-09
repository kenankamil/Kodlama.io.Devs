using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Domain;

namespace Application.Features.Technologies.Rules
{
    public class TechnologyBusinessRules
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly ITechnologyRepository _technologyRepository;

        public TechnologyBusinessRules(IProgrammingLanguageRepository programmingLanguageRepository, ITechnologyRepository technologyRepository)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _technologyRepository = technologyRepository;
        }

        public async Task ProgramminLanguageShouldBeExist(int id)
        {
            ProgrammingLanguage result = await _programmingLanguageRepository.GetAsync(p => p.Id == id);
            if (result == null) throw new BusinessException("Language id does not exist.");
        }

        public async Task TechnologyIdSouldBeExistWhenDeleted(int id)
        {
            Technology result = await _technologyRepository.GetAsync(p => p.Id == id);
            if (result == null) throw new BusinessException("Technology id does not exist.");
        }
    }
}
