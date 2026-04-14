using Asp1.Dto;

namespace Asp1.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    private IUserRepository _userRepository = userRepository;

    public Task<List<User>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<User> PostUserAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> PutUserAsync(UserDto userDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUserAsync(UserDto userDto)
    {
        throw new NotImplementedException();
    }

    public Task PostActivateAsync(int id)
    {
        throw new NotImplementedException();
    }
}