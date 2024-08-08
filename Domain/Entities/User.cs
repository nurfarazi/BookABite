namespace Domain.Entities;

public class User
{
    public int Id { get; set; } = Guid.NewGuid().GetHashCode();
    public string? Email { get; set; }
    public string? Name { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
}