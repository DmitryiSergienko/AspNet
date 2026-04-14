using Asp1.Dto;

namespace Asp1.Services;

public interface IUserService
{
    Task<List<UserDto>> GetUsersAsync();
    Task<UserDto> GetUserAsync(int id);
    Task<UserCreateDto> PostUserAsync();
    Task<UserUpdateDto> PutUserAsync(UserDto userDto);
    Task DeleteUserAsync(UserDto userDto);
    Task PostActivateAsync(int id);
}