namespace Asp1.Dto;

public class UserCreateDto
{
    public UserCreateDto(string? firstName, string? lastName, string? email, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        DateOfBirth = dateOfBirth;
    }

    public string? FirstName {set;get;}
    public string? LastName {set;get;}
    public string? Email {set;get;}
    public DateTime DateOfBirth {set;get;}
}