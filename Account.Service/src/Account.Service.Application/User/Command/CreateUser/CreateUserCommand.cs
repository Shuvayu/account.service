using Account.Service.Application.User.Model;
using MediatR;

namespace Account.Service.Application.User.Command.CreateUser
{
    public class CreateUserCommand : IRequest<UserDto>
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the monthly salary
        /// </summary>
        public decimal MonthlySalary { get; set; }

        /// <summary>
        /// Gets or sets the monthly expenses
        /// </summary>
        public decimal MonthlyExpenses { get; set; }
    }
}
