using Account.Service.Domain.Enumeration;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Service.Application.Account.Command.CreateAccount
{
    public class CreateAccountCommandValidator : AbstractValidator<CreateAccountCommand>
    {
        public CreateAccountCommandValidator()
        {
            RuleFor(x => x.UserId).GreaterThan(0);
            RuleFor(x => x.AccountType)
                        .NotEmpty()
                        .Must(x => x == "Personal" || x == "Business")
                        .WithMessage("Account Type must be either Personal or Business type.");
        }
    }
}
