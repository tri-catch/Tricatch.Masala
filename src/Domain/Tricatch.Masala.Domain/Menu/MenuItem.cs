namespace Tricatch.Masala.Domain.Menu;

public class MenuItem
{
    public int Id { get; set; }

    public int LocationMenuId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public string Image { get; set; } = string.Empty;

    public MenuCategory Category { get; set; } = MenuCategory.None;
}