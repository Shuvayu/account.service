using FluentValidation;

namespace Account.Service.Application.User.Command.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(255);
            RuleFor(x => x.Email).NotEmpty().MaximumLength(255);
            RuleFor(x => x.MonthlySalary).GreaterThanOrEqualTo(0);
            RuleFor(x => x.MonthlyExpenses).GreaterThanOrEqualTo(0);
        }
    }
}
