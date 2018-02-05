using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Origin.Bussines.Interface
{
    public interface IBaseSevice:IDisposable
    {
        /// <summary>
        /// 提供ID返回实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        T FindT<T>(string id) where T : class;
        /// <summary>
        /// 返回一个单表查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="funcWhere"></param>
        /// <returns></returns>
        IQueryable<T> ExcuteQueryable<T>(Expression<Func<T, bool>> funcWhere) where T : class;

        /// <summary>
        /// 返回一个指定sql语句的集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        IQueryable<T> ExcuteSql<T>(string sql, SqlParameter[] parameter) where T : class;

        /// <summary>
        /// 返回指定实体的所有数据列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        List<T> FindIQueryable<T>() where T : class;
    }
}
