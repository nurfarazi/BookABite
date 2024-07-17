namespace Application.Services.Authentication;

public interface IAuthenticationService
{
    Task<AuthenticationResult> RegisterAsync(string email, string password, string name);
    Task<AuthenticationResult> LoginAsync(string email, string password);
}