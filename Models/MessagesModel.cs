using System.ComponentModel.DataAnnotations;

public class Messages
{
    public int MessageId { get; set; }
    [Key]
    public string? Message { get; set; }
    public string? User { get; set; }
    public string? Time { get; set; }

}