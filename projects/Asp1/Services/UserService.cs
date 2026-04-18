using Asp1.Dto;
using Asp1.Repositories;

namespace Asp1.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    private readonly IMappingService _mappingService = new MappingService();
    
    public async Task<List<UserDto>> GetUsersAsync() =>
        _mappingService.GetUsers(await userRepository.GetUsersAsync());

    public async Task<UserDto> GetUserAsync(int id)
    {
        var user = await userRepository.GetUserAsync(id);
        if (user != null) return _mappingService.GetUser(user);
        return null;
    }
        
    
    public async Task<UserDto> PostUserAsync(UserCreateDto userCreateDto)
    {
        var user = await userRepository.AddtUserAsync(_mappingService.GetUserCreate(userCreateDto));
        return _mappingService.GetUser(user);
    }

    public async Task<UserDto> PutUserAsync(UserUpdateDto userUpdateDto)
    {
        var user = await userRepository.GetUserUpdateAsync(_mappingService.GetUserUpdate(userUpdateDto));
        return _mappingService.GetUser(user);
    }

    public async Task DeleteUserAsync(UserUpdateDto userUpdateDto) =>
        await userRepository.GetUserDeleteAsync(_mappingService.GetUserUpdate(userUpdateDto));

    public async Task PostActivateAsync(int id) => await userRepository.GetUserActiveAsync(id);
}