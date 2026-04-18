using Asp1.Dto;

namespace Asp1.Services;

public interface IUserService
{
    Task<List<UserDto>> GetUsersAsync();
    Task<UserDto> GetUserAsync(int id);
    Task<UserDto> PostUserAsync(UserCreateDto userCreateDto);
    Task<UserDto> PutUserAsync(UserUpdateDto userUpdateDto);
    Task DeleteUserAsync(UserUpdateDto userUpdateDto);
    Task PostActivateAsync(int id);
}