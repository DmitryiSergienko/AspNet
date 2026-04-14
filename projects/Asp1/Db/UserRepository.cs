using Asp1.Dto;
using Asp1.Services;

namespace Asp1;

public class UserRepository : IUserRepository
{
    public Task<List<User>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<User> ImportUserAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserUpdateDtoAsync(UserUpdateDto userUpdateDto)
    {
        throw new NotImplementedException();
    }
}