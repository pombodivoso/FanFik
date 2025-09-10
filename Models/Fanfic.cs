namespace FanFik.Models;

public class Fanfic
{
    public Guid FanficId { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public required Guid CreatorId { get; set; }
    public required User Creator { get; set; }
    public ICollection<ReadList> Lists { get; set; }
}