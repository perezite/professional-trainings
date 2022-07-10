using MediatR;
using Microsoft.EntityFrameworkCore;
using WebApi.Abstraction.Responses.User;
using WebApi.Repository.Context;

namespace WebApi.Application.Users.Queries.GetUsers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, IList<GetUserDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetUsersQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<GetUserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var dtos = _dbContext.Users.Select(user => user.MapTo());
            return await dtos.ToListAsync();
        }
    }
}
