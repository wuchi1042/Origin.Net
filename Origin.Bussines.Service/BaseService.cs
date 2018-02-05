using Origin.Bussines.Interface;
using Origin.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Origin.Bussines.Service
{
    
    public class BaseService:IBaseSevice
    {
        private OriginDbContext context = new OriginDbContext();


        public IQueryable<T> ExcuteSql<T>(string sql, SqlParameter[] parameter) where T : class
        {
            return context.Database.SqlQuery<T>(sql, parameter).AsQueryable();
        }
        public List<T> FindIQueryable<T>() where T : class
        {
            return context.Set<T>().ToList();
        }

        public T FindT<T>(string id) where T : class
        {
            return context.Set<T>().Find(id);
        }

        public IQueryable<T> ExcuteQueryable<T>(Expression<Func<T, bool>> funcWhere) where T : class
        {
            return context.Set<T>().Where<T>(funcWhere);
        }

        public virtual void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }
    }
}
