using Application.Common.Interfaces.Authentication;

namespace Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public Task<AuthenticationResult> RegisterAsync(string email, string password, string name)
    {
        var token = _jwtTokenGenerator.GenerateToken(Guid.NewGuid(), email, name);

        return Task.FromResult(new AuthenticationResult
        {
            Token = token,
            Email = email,
            Name = name
        });
    }

    public Task<AuthenticationResult> LoginAsync(string email, string password)
    {
        throw new NotImplementedException();
    }
}