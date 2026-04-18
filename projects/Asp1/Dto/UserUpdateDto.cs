namespace Asp1.Dto;

public class UserUpdateDto
{
    public int Id {init;get;}
    public string? FirstName {set;get;}
    public string? LastName {set;get;}
    public string? Email {set;get;}
    public DateTime DateOfBirth {set;get;}
    public bool IsActive {set;get;}
}