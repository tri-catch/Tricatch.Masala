namespace Tricatch.Masala.Domain.Menu;

public class LocationMenu
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public int ZipCode { get; set; }

    public required List<MenuItem> Items { get; set; }
}
