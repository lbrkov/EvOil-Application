using System.Threading;
using System.Net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using EvOil.Business.Services.Abstractions;
using EvOil.Business.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace EvOil.WebApi.Controllers
{
    [ApiController]
    [Route("api/")]
    public class UserController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UserController(IUsersService usersService)
        {
            _usersService = usersService;
        }
        [HttpPost]
        [Route("users")]
        public async Task<IActionResult> SetUser(
            [FromQuery] UserDto userDto,
            CancellationToken cancellationToken)
        {
            await _usersService.SetUser(
                userDto: userDto,
                cancellationToken: cancellationToken
            );

            return CreatedAtAction(nameof(SetUser), userDto);
        }
        [HttpGet]
        [Route("test")]
        public string Test() => "Hola Mundo!";

        [HttpGet]
        [Route("users")]
        public async Task<IActionResult> GetUsers(
            CancellationToken cancellationToken
        )
        {
            var users = await _usersService.GetUsers(cancellationToken);

            return Ok(users);
        }
        [HttpGet]
        [Route("users/{id}")]
        public async Task<IActionResult> GetUserById(
        [FromRoute] int id,
         CancellationToken cancellationToken)
        {
            var userbyid = await _usersService.GetUserById(
                id: id,
                cancellationToken: cancellationToken
            );

            return Ok(userbyid);
        }
        [HttpDelete]
        [Route("users/{username}")]
        public async Task<IActionResult> RemoveUser(
            [FromRoute] string username,
            CancellationToken cancellationToken
        )
        {
            await _usersService.RemoveUser(
                username: username,
                cancellationToken: cancellationToken
            );
            return Ok();
        }
    }
}