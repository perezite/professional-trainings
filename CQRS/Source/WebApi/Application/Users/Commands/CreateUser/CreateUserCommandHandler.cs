using MediatR;
using WebApi.Abstraction.Responses.User;
using WebApi.Repository.Context;

namespace WebApi.Application.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateUserCommandHandler(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task<CreateUserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = request.CreateUser();

            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return new CreateUserDto(user.Id);
        }
    }
}
