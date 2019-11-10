using Account.Service.Application.User.Model;

namespace Account.Service.Application.Account.Model
{
    public class AccountDto
    {
        /// <summary>
        /// Gets or sets the account id
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// Gets or sets the user
        /// </summary>
        public UserDto User { get; set; }

        /// <summary>
        /// Gets or sets the account type
        /// </summary>
        public string AccountType { get; set; }
    }
}
