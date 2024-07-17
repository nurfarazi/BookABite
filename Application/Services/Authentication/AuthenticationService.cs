namespace Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public Task<AuthenticationResult> RegisterAsync(string email, string password, string name)
    {
        throw new NotImplementedException();
    }

    public Task<AuthenticationResult> LoginAsync(string email, string password)
    {
        throw new NotImplementedException();
    }
}