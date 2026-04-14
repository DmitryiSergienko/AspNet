using Asp1.Dto;

namespace Asp1.Services;

public class MappingService : IMappingService
{
    public List<UserDto> GetUsers(List<User> users)
    {
        
    }

    public UserDto GetUser(User user)
    {
        UserDto userDto = new UserDto();
        userDto.Id = user.Id;
        userDto.FirstName = user.FirstName;
        userDto.LastName = user.LastName;
        userDto.Email = user.Email;
        user.DateOfBirth = user.DateOfBirth;
        user.IsActive = user.IsActive;
        return userDto;
    }
    
    public User GetUser(UserDto userDto)
    {
        User user = new User();
        user.Id = userDto.Id;
        user.FirstName = userDto.FirstName;
        user.LastName = userDto.LastName;
        user.Email = userDto.Email;
        user.DateOfBirth = userDto.DateOfBirth;
        user.IsActive = userDto.IsActive;
        return user;
    }
    
    public User GetUserCreate(UserCreateDto userCreateDto)
    {
        User user = new User();
        user.FirstName = userCreateDto.FirstName;
        user.LastName = userCreateDto.LastName;
        user.Email = userCreateDto.Email;
        user.DateOfBirth = userCreateDto.DateOfBirth;
        return user;
    }

    public User GetUserUpdate(UserUpdateDto userUpdateDto)
    {
        User user = new User();
        user.Id = userUpdateDto.Id;
        user.FirstName = userUpdateDto.FirstName;
        user.LastName = userUpdateDto.LastName;
        user.Email = userUpdateDto.Email;
        user.DateOfBirth = userUpdateDto.DateOfBirth;
        user.IsActive = userUpdateDto.IsActive;
        return user;
    }
}