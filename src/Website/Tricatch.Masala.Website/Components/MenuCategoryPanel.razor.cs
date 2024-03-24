using Microsoft.AspNetCore.Components;
using Tricatch.Masala.Domain.Menu;

namespace Tricatch.Masala.Website.Components;

public partial class MenuCategoryPanel
{
    [Parameter]
    public EventCallback<MenuCategory> CategoryChanged { get; set; }

    private int _activeTabIndex { get; set; }

    protected override void OnInitialized()
    {
        _activeTabIndex = 0;
    }

    private async Task OnTabChanged(int tabIndex)
    {
        _activeTabIndex = tabIndex;
        await CategoryChanged.InvokeAsync((MenuCategory)tabIndex);
    }
}
