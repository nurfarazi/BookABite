using Application.Common.Interfaces.Authentication;
using Application.Common.Interfaces.Persistence;
using Domain.Entities;

namespace Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public async Task<AuthenticationResult> RegisterAsync(string email, string password, string name)
    {
        // check user exist
        var user = await _userRepository.GetByEmailAsync(email);

        if (user != null) throw new Exception("User already exists");

        // check password add more validation
        if (await _userRepository.CheckPasswordAsync(email, password)) throw new Exception("Password is not valid");

        // create user
        user = new User
        {
            Email = email,
            Name = name,
            Password = password
        };

        _userRepository.AddAsync(user);

        // generate token
        var token = _jwtTokenGenerator.GenerateToken(user.Id, email, name);

        return await Task.FromResult(new AuthenticationResult
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