using Account.Service.Application.Common.Query;
using Account.Service.Application.Tests.Common;
using Account.Service.Application.User.Model;
using Account.Service.Application.User.Query.GetUser;
using Account.Service.Persistence;
using AutoMapper;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Account.Service.Application.Tests.User.Query
{
    public class GetUserQueryHandlerTests
    {
        private readonly AccountDbContext _context;
        private readonly IMapper _mapper;

        public GetUserQueryHandlerTests(QueryTestFixture fixture)
        {
            _context = fixture.Context;
            _mapper = fixture.Mapper;
        }

        [Fact]
        public async Task GetUserTest()
        {
            var sut = new GetUserQueryHandler(_context, _mapper);

            var result = await sut.Handle(new GetQuery<UserDto>(), CancellationToken.None);

            result.ShouldBeOfType<UserDto>();
        }
    }
}
