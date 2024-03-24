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
            Primary = Colors.Orange.Darken3,
            AppbarBackground = Colors.Shades.White,
            AppbarText = Colors.Shades.Black,
            TextPrimary = Colors.Shades.Black,
            Dark = Colors.Shades.Black,
        };
    }
}
