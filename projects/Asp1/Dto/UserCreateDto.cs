using System.ComponentModel.DataAnnotations;

namespace Asp1.Dto;

public class UserCreateDto
{
    public string? FirstName {set;get;}
    public string? LastName {set;get;}
    public string? Email {set;get;}
    [DataType(DataType.Date)]
    public DateTime DateOfBirth {set;get;}
}