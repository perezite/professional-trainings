using WebApi.Core.Enums;

namespace WebApi.Domain.Entities.User
{
    public class User
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public UserDepartment Department { get; set; }
    }
}
