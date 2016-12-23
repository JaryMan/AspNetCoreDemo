using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        /// <summary>
        /// 序列化
        /// </summary>
        /// <returns></returns>
        public string Serializable()
        {
            var json = new StringBuilder();
            json.Append("{");
            json.Append(string.Concat("\"UserName\":", UserName, ","));
            json.Append(string.Concat("\"UserName\":", Password));
            json.Append("}");
            return json.ToString();
        }
    }
}
