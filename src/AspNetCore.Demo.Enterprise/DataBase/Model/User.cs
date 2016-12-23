using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Demo.Enterprise.DataBase.Model
{

    public class User
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        
        public SelectParameter SelectParameter { get; set; }

        public int ID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}
