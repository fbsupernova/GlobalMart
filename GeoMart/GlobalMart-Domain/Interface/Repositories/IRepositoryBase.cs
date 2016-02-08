
using System.Collections.Generic;


namespace GlobalMart_Domain.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetbyId(int id);
        void Update(TEntity obj);
        void Revmove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        void Dispose();


    }
}
