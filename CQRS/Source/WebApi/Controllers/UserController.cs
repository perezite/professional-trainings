using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstraction.Requests.User;
using WebApi.Application.Users.Commands.CreateUser;
using WebApi.Application.Users.Queries.GetUsers;

namespace WebApi.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _mediator.Send(new GetUsersQuery());
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            var users = await _mediator.Send(new CreateUserCommand(
                request.Name, request.Department));

            return Ok(users);
        }
    }
}
