namespace Asp1.Dto;

public class UserDto
{
    UserDto(int id, string firstName, string lastName, string email, DateTime dateOfBirth, bool isActive)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        DateOfBirth = dateOfBirth;
        IsActive = isActive;
    }
    private int Id {set;get;}
    private string FirstName {set;get;}
    private string LastName {set;get;}
    private string Email {set;get;}
    private DateTime DateOfBirth {set;get;}
    private bool IsActive {set;get;}
}