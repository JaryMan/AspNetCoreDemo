using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Demo.Enterprise.DateBase.Data.IDataClass
{
    public interface IDataBase<T>
    {
        /// <summary>
        /// 根据ID查询记录
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        T QueryForId(int id);

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        IList<T> QueryAll();

        /// <summary>
        /// 根据数量查询记录
        /// </summary>
        /// <param name="count">记录数</param>
        /// <returns></returns>
        IList<T> QueryForCount(int count);

        /// <summary>
        /// 查询总记录数
        /// </summary>
        /// <returns></returns>
        int QueryTotalCount();

        /// <summary>
        /// 查询分页记录
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageCount">显示数量</param>
        /// <returns></returns>
        IList<T> QueryPageList(int pageIndex, int pageCount);

        /// <summary>
        /// 根据ID删除记录
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        int DeleteForId(int id);
    }
}
