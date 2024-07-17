using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Contracts.Authentication;

public class LoginRequest
{
    [Required] [EmailAddress] public required string Email { get; set; }
    [Required] [PasswordPropertyText] public required string Password { get; set; }
}