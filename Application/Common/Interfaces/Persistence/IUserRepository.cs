using Domain.Entities;

namespace Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    Task<User> GetByIdAsync(int id);
    Task<bool> CheckPasswordAsync(string email, string password);
    Task<User> GetByEmailAsync(string email);
    void AddAsync(User user);
    Task<User> UpdateAsync(User user);
}