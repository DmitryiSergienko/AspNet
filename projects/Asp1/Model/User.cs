namespace Asp1;

enum Roles
{
    Admin,
    User
}

public class User
{
    public int Id {set;get;}
    public string? FirstName {set;get;}
    public string? LastName {set;get;}
    public string? Email {set;get;}
    public DateTimeOffset DateOfBirth {set;get;}
    public bool IsActive {set;get;}
    public Roles? Role {set;get;} = Roles.User;
}