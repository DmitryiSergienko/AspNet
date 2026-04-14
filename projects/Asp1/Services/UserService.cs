using Asp1.Dto;

namespace Asp1.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    private IUserRepository _userRepository = userRepository;
    private IMappingService _mappingService = new MappingService();
    
    public Task<List<UserDto>> GetUsersAsync()
    {
        return _mappingService.GetUserDto(_userRepository.GetUsersAsync());
    }

    public Task<UserDto> GetUserAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<UserCreateDto> PostUserAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UserUpdateDto> PutUserAsync(UserDto userDto)
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