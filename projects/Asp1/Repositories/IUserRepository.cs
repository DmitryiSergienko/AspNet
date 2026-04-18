namespace Asp1.Repositories;

public interface IUserRepository
{
    public Task<List<User>> GetUsersAsync();
    public Task<User?> GetUserAsync(int id);
    public Task<User> AddtUserAsync(User user);
    public Task<User> GetUserUpdateAsync(User user);
    public Task GetUserDeleteAsync(User user);
    public Task<User?> GetUserActiveAsync(int id);
}