using Mars.Entities;

namespace Mars.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        void Dispose();
        void Dispose(bool disposing);
        IRepository<T> Repository<T>() where T : BaseEntity;
        void Save();
    }
}