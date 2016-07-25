using AspNetCore.Demo.Enterprise.DateBase.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Text;

namespace AspNetCore.Demo.Enterprise.DateBase.Data
{
    public partial class UserData
    {
        private DbConnection dbConnection = new DbConnection();

        /// <summary>
        /// 插入一条数据
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public int Insert(User entity)
        {
            //if (!entity.Validator()) return 0;
            var parameters = new DynamicParameters();
            var updateStr = new StringBuilder();
            var sqlStr = string.Format("Insert Into User(UserName,Password) Values(@UserName,@Password)", updateStr);
            return dbConnection.connection.Execute(sqlStr, parameters);
        }
    }
}
