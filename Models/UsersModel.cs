using System.ComponentModel.DataAnnotations;

public class Users
{
    public int UserId { get; set; }
    [Key]
    public string? User { get; set; }

    public string? Password { get; set; }


}