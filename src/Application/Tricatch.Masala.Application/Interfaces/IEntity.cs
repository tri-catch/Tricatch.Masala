namespace Tricatch.Masala.Application.Interfaces;

public interface IEntity
{
    public DateTime CreatedDateUTC { get; set; }
    public DateTime LastModifiedDateUTC { get; set; }
}
