using Asp1.Dto;

namespace Asp1.Services;

public interface IMappingService
{
    public List<UserDto> GetUsers(List<User> users);
    public UserDto GetUser(User user);
    public User GetUser(UserDto userDto);
    public User GetUserCreate(UserCreateDto userCreateDto);
    public User GetUserUpdate(UserUpdateDto userUpdateDto);
}