using System.ComponentModel.DataAnnotations;

namespace Contracts.Authentication;

public class RegisterRequest : LoginRequest
{
    [MinLength(2)] 
    public required string Name { get; set; }
}