using Microsoft.AspNetCore.Components;
using Tricatch.Masala.Application.Interfaces;
using Tricatch.Masala.Domain.Menu;

namespace Tricatch.Masala.Website.Components.Pages;

public partial class Menu
{
    [Inject]
    IMenuItemRepository? MenuItemRepository { get; set; }

    private IEnumerable<MenuItem> _menuItems { get; set; } = new List<MenuItem>();
    private IList<MenuItem> _displayMenuItems { get; set; } = new List<MenuItem>();
    private MenuCategory _selectedCategory { get; set; }

    protected override async Task OnInitializedAsync()
    {
        _menuItems = await MenuItemRepository!.GetMenuItemsAsync();
        _displayMenuItems = _menuItems.ToList();
        _selectedCategory = MenuCategory.None;
    }

    private void OnCategorySwitched(MenuCategory category) 
    {
        _selectedCategory = category;

        if (_selectedCategory == MenuCategory.None)
        {
            _displayMenuItems = _menuItems.ToList();
        }
        else
        {
            _displayMenuItems = _menuItems
                .Where(x => x.Category == _selectedCategory)
                .ToList();
        }
    }

}
