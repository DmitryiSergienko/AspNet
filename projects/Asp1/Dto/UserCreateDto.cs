namespace Asp1.Dto;

public class UserCreateDto
{
    public UserCreateDto(string firstName, string lastName, string email, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        DateOfBirth = dateOfBirth;
    }

    private string FirstName {set;get;}
    private string LastName {set;get;}
    private string Email {set;get;}
    private DateTime DateOfBirth {set;get;}
}