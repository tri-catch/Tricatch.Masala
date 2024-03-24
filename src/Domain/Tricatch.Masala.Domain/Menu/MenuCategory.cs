using System.ComponentModel;

namespace Tricatch.Masala.Domain.Menu;

public enum MenuCategory
{
    [Description("All Items")]
    None = 0,
    [Description("Platters")]
    Platter = 1,
    [Description("Appetizers")]
    Appetizer = 2,
    [Description("Wraps")]
    Wraps = 3,
    [Description("Pizza")]
    Pizza = 4,
    [Description("Naan")]
    Naan = 5,
    [Description("Dessert")]
    Dessert = 6,
    [Description("Drinks")]
    Drink = 7,
}