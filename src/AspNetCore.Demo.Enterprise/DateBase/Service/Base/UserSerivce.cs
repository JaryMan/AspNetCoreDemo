using AspNetCore.Demo.Enterprise.DateBase.Data;
using AspNetCore.Demo.Enterprise.DateBase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Demo.Enterprise.DateBase.Service
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
