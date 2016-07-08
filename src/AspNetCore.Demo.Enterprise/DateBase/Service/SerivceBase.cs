using AspNetCore.Demo.Enterprise.DateBase.Data.DataClass;
using AspNetCore.Demo.Enterprise.DateBase.Data.IDataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Demo.Enterprise.DateBase.Service
{
    public class SerivceBase<T>
    {
        /// <summary>
        /// 根据ID查询记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public static T QueryForId(int id)
        {
            IDataBase<T> db = new DataBase<T>();
            return db.QueryForId(id);
        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public static IList<T> QueryAll()
        {
            IDataBase<T> db = new DataBase<T>();
            return db.QueryAll();
        }

        /// <summary>
        /// 根据查询数量获取记录
        /// </summary>
        /// <param name="count">记录数</param>
        /// <returns></returns>
        public static IList<T> QueryForCount(int count)
        {
            IDataBase<T> db = new DataBase<T>();
            return db.QueryForCount(count);
        }

        /// <summary>
        /// 查询总记录数
        /// </summary>
        /// <returns></returns>
        public static int QueryTotalCount()
        {
            IDataBase<T> db = new DataBase<T>();
            return db.QueryTotalCount();
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageCount">显示数</param>
        /// <returns></returns>
        public static IList<T> QueryPageList(int pageIndex,int pageCount)
        {
            IDataBase<T> db = new DataBase<T>();
            return db.QueryPageList(pageIndex, pageCount);
        }

        /// <summary>
        /// 根据ID删除记录
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public static bool DeleteForId(int id)
        {
            IDataBase<T> db = new DataBase<T>();
            return db.DeleteForId(id) > 0;
        }
    }
}
