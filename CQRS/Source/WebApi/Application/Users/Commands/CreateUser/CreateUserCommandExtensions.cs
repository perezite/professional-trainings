using WebApi.Domain.Entities.User;

namespace WebApi.Application.Users.Commands.CreateUser
{
    public static class CreateUserCommandExtensions
    {
        public static User CreateUser(this CreateUserCommand command)
        {
            var user = new User
            { 
                Name = command.Name,
                Department = command.Department
            };

            return user;
        }
    }
}
