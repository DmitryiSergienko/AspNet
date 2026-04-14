using Asp1.Dto;

namespace Asp1;

public interface IUserRepository
{
    public Task<List<User>> GetUsersAsync();
    public Task<User> GetUserAsync(int id);
    public Task<User> ImportUserAsync();
    public Task<User> GetUserUpdateDtoAsync(UserUpdateDto userUpdateDto);
}