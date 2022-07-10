using WebApi.Core.Enums;

namespace WebApi.Abstraction.Requests.User
{
    public class CreateUserRequest
    {
        public string? Name { get; set; }
        public UserDepartment Department { get; set; }
    }
}
