using AspNetCore.Demo.Enterprise.DataBase.Data;
using AspNetCore.Demo.Enterprise.DataBase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Demo.Enterprise.DataBase.Service
{
    public static partial class UserSerivce
    {
        /// <summary>
        /// 插入单条信息
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public static bool Insert(this User entity)
        {
            UserData data = new UserData();
            return data.Insert(entity) > 0;
        }
    }
}
