using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using AspNetCore.Demo.Enterprise.DateBase.Data.IDataClass;

namespace AspNetCore.Demo.Enterprise.DateBase.Data.DataClass
{
    public class DataBase<T>:IDataBase<T>
    {
        protected DbContent dbContent=new DbContent();

        /// <summary>
        /// 表名
        /// </summary>
        protected string tableName = typeof(T).ToString();


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
        public IList<T> QueryAll()
        {
            return dbContent.connection.Query<T>("select * from " + tableName).ToList();
        }
        
        /// <summary>
        /// 根据查询数量获取记录
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public IList<T> QueryForCount(int count)
        {
            var sqlStr = string.Format("select top {0} * from {1}", count, tableName);
            return dbContent.connection.Query<T>(sqlStr).ToList();
        }

        /// <summary>
        /// 查询总记录数
        /// </summary>
        /// <returns></returns>
        public int QueryTotalCount()
        {
            return dbContent.connection.QueryFirst<int>("select count(0) from " + tableName);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageCount">页面大小</param>
        /// <returns></returns>
        public IList<T> QueryPageList(int pageIndex,int pageCount)
        {
            var sqlStr = string.Format("SELECT TOP {0} * FROM(SELECT ROW_NUMBER() OVER(ORDER BY id) AS RowNumber, *FROM {2}) A WHERE RowNumber > {0} * ({1} - 1)", pageCount, pageIndex,tableName);
            return dbContent.connection.Query<T>(sqlStr).ToList();
        }

        /// <summary>
        /// 根据ID删除信息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public int DeleteForId(int id)
        {
            return dbContent.connection.Execute(string.Format("Delete from {0} where Id=@Id", tableName), id);
        }

        #region 异步

        /// <summary>
        /// 根据ID删除信息（异步）
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public async Task DeleteForIdAsync(int id)
        {
            await dbContent.connection.ExecuteAsync(string.Format("Delete from {0} where Id=@Id", tableName), id);
        }

        #endregion
    }
}
