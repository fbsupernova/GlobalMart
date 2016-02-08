using GlobalMart_Domain.Interface;
using GlobalMart_Infra_Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalMart_Infra_Data.Repositories
{
    public class RespositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected GlobalMartContext Db = new GlobalMartContext();
        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add();
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetbyId(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Revmove(TEntity obj)
        {
            Db.Set<TEntity>().Remove();
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
