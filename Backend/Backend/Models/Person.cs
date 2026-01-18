

using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class Person
{
    public int Id {get;set;}

    [Required]
    [MaxLength(30)]
    public string FirstName {get;set;} = string.Empty; //you can write "" also

    [Required]
    [MaxLength(30)]
    public string LastName {get;set;} = "";

}
