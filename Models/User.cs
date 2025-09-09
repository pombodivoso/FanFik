namespace FanFik.Models;

public class User
{
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string Bio { get; set; }
    public required DateTime CreationDate { get; set; } 
}