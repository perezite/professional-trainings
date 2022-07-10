using WebApi.Core.Enums;

namespace WebApi.Abstraction.Responses.User
{
    public class GetUserDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public UserDepartment Department { get; set; }
    }
}
