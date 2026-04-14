namespace Asp1.Dto;

public class UserDto
{
    public UserDto(){}
    public UserDto(int id, string? firstName, string? lastName, string? email, DateTime dateOfBirth, bool isActive)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        DateOfBirth = dateOfBirth;
        IsActive = isActive;
    }
    public int Id {set;get;}
    public string? FirstName {set;get;}
    public string? LastName {set;get;}
    public string? Email {set;get;}
    public DateTime DateOfBirth {set;get;}
    public bool IsActive {set;get;}
}