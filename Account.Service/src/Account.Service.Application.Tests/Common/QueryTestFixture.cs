using Account.Service.Persistence;
using AutoMapper;
using System;

namespace Account.Service.Application.Tests.Common
{
    public class QueryTestFixture : IDisposable
    {
        public AccountDbContext Context { get; private set; }
        public IMapper Mapper { get; private set; }

        public QueryTestFixture()
        {
            // Mock the context
           // Context = AccountDbContext();

            var configurationProvider = new MapperConfiguration(cfg =>
            {
                // TODO: Add all profiles
                // cfg.AddProfile<MappingProfile>();
            });

            Mapper = configurationProvider.CreateMapper();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
