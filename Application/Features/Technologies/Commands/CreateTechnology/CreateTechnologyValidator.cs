using FluentValidation;

namespace Application.Features.Technologies.Commands.CreateTechnology
{
    public class CreateTechnologyValidator : AbstractValidator<CreateTechnologyCommand>
    {
        public CreateTechnologyValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
        }
    }
}
