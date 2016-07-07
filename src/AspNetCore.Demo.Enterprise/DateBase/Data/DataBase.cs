using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace AspNetCore.Demo.Enterprise.DateBase.Data
{
    public class DataBase<T>
    {
        protected DbContent dbContent=new DbContent();



        /// <summary>
        /// 根据ID查询信息
        /// </summary>
        /// <param name="id">ID号</param>
        /// <returns></returns>
        public T QueryForId(int id)
        {
            return dbContent.connection.QueryFirstOrDefault<T>("select Id=@Id", id);
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public List<T> QueryAll()
        {
            return dbContent.connection.Query<T>("").ToList();
        }
    }
}
