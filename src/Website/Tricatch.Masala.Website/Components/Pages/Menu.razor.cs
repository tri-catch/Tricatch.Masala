using Microsoft.AspNetCore.Components;
using Tricatch.Masala.Application.Interfaces;
using Tricatch.Masala.Domain.Menu;

namespace Tricatch.Masala.Website.Components.Pages;

public partial class Menu
{
    [Inject]
    IMenuItemRepository? MenuItemRepository { get; set; }

    private IEnumerable<MenuItem>? _menuItems { get; set; }
    private int _selectedCategoryId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        _menuItems = await MenuItemRepository!.GetMenuItemsAsync();
        _selectedCategoryId = 0;
    }

    private void OnCategorySwitched(int categoryId) 
    {
        _selectedCategoryId = categoryId;
    }

}
