using Microsoft.AspNetCore.Components;
using MudBlazor;
using Tricatch.Masala.Website.Theme;

namespace Tricatch.Masala.Website.Components.Layout;

public partial class MasalaAppBar
{
    [Parameter]
    public bool IsDrawerOpen { get; set; }

    [Parameter]
    public EventCallback OnDrawerToggle { get; set; }

    private Color _shoppingCartColor = Color.Dark;

    private async Task DrawerToggle()
    {
        IsDrawerOpen = !IsDrawerOpen;
        _shoppingCartColor = IsDrawerOpen ? Color.Primary : Color.Dark;

        await OnDrawerToggle.InvokeAsync();
    }
}
