namespace FanFik.Models;

public class User
{
    public Guid UserId { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string Bio { get; set; }
    public required DateTime CreationDate { get; set; }
    public ICollection<Fanfic> CreatedFanfictions { get; set; }
    public ICollection<ReadList> AllLists { get; set; }
}