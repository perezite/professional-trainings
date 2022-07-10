using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Abstraction.Requests.User;
using WebApi.Application.Users.Commands.CreateUser;

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

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            var users = await _mediator.Send(new CreateUserCommand(
                request.Name, request.Department));

            return Ok(users);
        }
    }
}
