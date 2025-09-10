namespace FanFik.Models;

public class ReadList
{
    public Guid RaedListId { get; set; }
    public required string ListName { get; set; }
    public required Guid CreatorId { get; set; }
    public required User Creator { get; set; }
    public required DateTime ModificationDate { get; set; }
    public ICollection<Fanfic> Fanfictions { get; set; }
}