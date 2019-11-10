using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Service.Persistence
{
    public class AccountDbInitializer
    {
         public static void Initialize(AccountDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
