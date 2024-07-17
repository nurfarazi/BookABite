using Application.Services.Authentication;
using Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController
{
    private readonly IAuthenticationService _authenticationService;

    public AuthController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync([FromBody] RegisterRequest request)
    {
        var result = await _authenticationService.RegisterAsync(request.Email, request.Password, request.Name);
        return new JsonResult(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync([FromBody] LoginRequest request)
    {
        var result = await _authenticationService.LoginAsync(request.Email, request.Password);
        return new JsonResult(result);
    }
}