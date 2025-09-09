namespace FanFik.Models;

public class ReadList
{
    public required string ListName { get; set; }
    public required DateTime ModificationDate { get; set; }
    public ICollection<Fanfic> Fanfictions { get; set; }
}