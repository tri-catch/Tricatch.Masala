using MudBlazor;

namespace Tricatch.Masala.Website.Theme;

public class WebsiteTheme : MudTheme
{

    /// <summary>
    /// Our site theme is an extension of Mudblazor's MudTheme. For a full list of Mudblazor's colors
    /// see this page: https://mudblazor.com/features/colors#material-colors-list-of-material-colors
    /// </summary>
    public WebsiteTheme()
    {
        Palette = new PaletteLight()
        {
            AppbarBackground = Colors.Amber.Darken2
        };
    }
}
