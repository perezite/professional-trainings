namespace WebApi.Abstraction.Responses.User
{
    public class CreateUserDto
    {
        public CreateUserDto(long id)
        {
            Id = id;
        }

        public long Id { get; set; }
    }
}
