using WebApi.Abstraction.Responses.User;
using WebApi.Domain.Entities.User;

namespace WebApi.Application.Users.Queries.GetUsers
{
    public static class GetUsersQueryExtensions
    {
        public static GetUserDto MapTo(this User user)
        {
            return new GetUserDto
            {
                Id = user.Id,
                Name = user.Name,
                Department = user.Department
            };
        }
    }
}
