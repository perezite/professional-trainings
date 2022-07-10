using MediatR;
using WebApi.Abstraction.Responses.User;

namespace WebApi.Application.Users.Queries.GetUsers
{
    public class GetUsersQuery : IRequest<IList<GetUserDto>>
    {
    }
}
