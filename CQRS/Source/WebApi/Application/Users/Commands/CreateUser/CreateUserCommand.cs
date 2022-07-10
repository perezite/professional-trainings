using MediatR;
using WebApi.Abstraction.Responses.User;
using WebApi.Core.Enums;

namespace WebApi.Application.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<CreateUserDto>
    {
        public CreateUserCommand(string? name, UserDepartment department)
        {
            Name = name;
            Department = department;
        }

        public string? Name { get; set; }
        public UserDepartment Department { get; set; }
    }
}
