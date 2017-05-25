using System.Linq;
using Mars.Entities;

namespace Mars.Repository.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Table { get; }

        void Delete(T entity);
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
    }
}