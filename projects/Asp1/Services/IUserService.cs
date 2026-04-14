using Asp1.Dto;

namespace Asp1.Services;

public interface IUserService
{
    Task<List<User>> GetUsersAsync();
    Task<User> GetUserAsync(int id);
    Task<User> PostUserAsync();
    Task<User> PutUserAsync(UserDto userDto);
    Task DeleteUserAsync(UserDto userDto);
    Task PostActivateAsync(int id);
}