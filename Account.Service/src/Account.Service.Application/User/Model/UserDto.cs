using System;

namespace Account.Service.Application.User.Model
{
    public class UserDto
    {
        /// <summary>
        /// Gets or sets the user id
        /// </summary>
        public int UserId { get; set; }

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
