namespace Tricatch.Masala.Application.Interfaces;

public interface IRepository
{
    IUnitOfWork UnitOfWork { get; }
}
