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

    private const string _menuText = "Menu";
    private Color _menuTextColor = Color.Primary;

    private const string _aboutText = "About";
    private Color _aboutTextColor = Color.Dark;

    private const string _contactUsText = "Contact Us";
    private Color _contactUsTextColor = Color.Dark;

    private async Task DrawerToggle()
    {
        IsDrawerOpen = !IsDrawerOpen;
        _shoppingCartColor = IsDrawerOpen ? Color.Primary : Color.Dark;

        await OnDrawerToggle.InvokeAsync();
    }

    private void SetActiveTabColor(string activeTab)
    {
        _menuTextColor = activeTab == _menuText ? Color.Primary : Color.Dark;
        _aboutTextColor = activeTab == _aboutText ? Color.Primary : Color.Dark;
        _contactUsTextColor = activeTab == _contactUsText ? Color.Primary : Color.Dark;

        StateHasChanged();
    }
}
