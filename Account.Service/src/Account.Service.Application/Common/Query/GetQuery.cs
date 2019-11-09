using MediatR;

namespace Account.Service.Application.Common.Query
{
    public class GetQuery<T> : IRequest<T>
    {
        /// <summary>
        /// get sets the ID an entity
        /// </summary>
        public int Id { get; set; }
    }
}
