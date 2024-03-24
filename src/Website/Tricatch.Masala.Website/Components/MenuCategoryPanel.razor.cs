using Microsoft.AspNetCore.Components;

namespace Tricatch.Masala.Website.Components;

public partial class MenuCategoryPanel
{
    [Parameter]
    public EventCallback<int> CategoryChanged { get; set; }

    private int _activeTabIndex { get; set; }

    protected override void OnInitialized()
    {
        _activeTabIndex = 0;
    }

    private async Task OnTabChanged(int tabIndex)
    {
        _activeTabIndex = tabIndex;
        await CategoryChanged.InvokeAsync(tabIndex);
    }
}
