using FluentValidation;

namespace Blazorcrud.Shared.Models
{
    public class RoleValidator : AbstractValidator<Role>
    {
        public RoleValidator()
        {
            ClassLevelCascadeMode = CascadeMode.Stop;

            RuleFor(role => role.Name).NotEmpty().WithMessage("Role is required to have a name.")
                .Length(3, 50).WithMessage("Role name must be between 3 and 50 characters.");
            RuleFor(role => role.Description).NotEmpty().WithMessage("Description is a required field.")
                .Length(3, 50).WithMessage("Description must be between 3 and 250 characters.");
        }
    }
}