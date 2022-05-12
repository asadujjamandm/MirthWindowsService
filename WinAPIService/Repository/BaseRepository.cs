using Mirth.Contracts;
using Mirth.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WinAPIService.Repository;

namespace Mirth.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private BacktalkDBEntities _backtalkDBEntities = null;
        private DbSet<T> table = null;        
        private string ConnString = ConfigurationManager.ConnectionStrings["BacktalkDBEntities"].ConnectionString.ToString();

        public BaseRepository()
        {            
            Logger.log.Info(this.ConnString);
            this._backtalkDBEntities = new BacktalkDBEntities(this.ConnString);
            this.table = _backtalkDBEntities.Set<T>();
        }

        public void Add(T item)
        {
            table.Add(item);
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _backtalkDBEntities.Set<T>().Where(expression);
        }              

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetByID(object id)
        {
            return table.Find(id);
        }

        public async Task Save()
        {
            await _backtalkDBEntities.SaveChangesAsync();
        }

        public async Task Update(T item)
        {
            table.Attach(item);
            _backtalkDBEntities.Entry(item).State = System.Data.Entity.EntityState.Modified;
            await _backtalkDBEntities.SaveChangesAsync();
        }

        public void Dispose()
        {
            _backtalkDBEntities.Dispose();
        }
    }
}
