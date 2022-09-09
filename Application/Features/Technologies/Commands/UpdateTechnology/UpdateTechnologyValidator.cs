using Application.Features.Technologies.Commands.UpdateTechnology;
using FluentValidation;

namespace Application.Features.Technologies.Commands.CreateTechnology
{
    public class UpdateTechnologyValidator : AbstractValidator<UpdateTechnologyCommand>
    {
        public UpdateTechnologyValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
        }
    }
}
