using Asp1.Db;
using Microsoft.EntityFrameworkCore;

namespace Asp1.Repositories;

public class UserRepository(AppDbContext context) : IUserRepository
{
    public async Task<List<User>> GetUsersAsync() => 
        await context.Users.ToListAsync();

    public async Task<User?> GetUserAsync(int id) =>
        await context.Users.FirstOrDefaultAsync(u => u.Id == id);

    public async Task<User> AddtUserAsync(User user)
    {
        await context.Users.AddAsync(user);
        await context.SaveChangesAsync();
        return user;
    }
        

    public async Task<User> GetUserUpdateAsync(User user)
    {
        context.Users.Update(user);
        await context.SaveChangesAsync();
        return user;
    }
    
    public async Task GetUserDeleteAsync(User user)
    {
        context.Users.Remove(user);
        await context.SaveChangesAsync();
    }
    
    public async Task<User?> GetUserActiveAsync(int id)
    {
        User? user = await context.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user != null)
        {
            user.IsActive = !user.IsActive;
            return await GetUserUpdateAsync(user);
        }
        return null;
    }
}