using AspNetCore.Demo.Enterprise.DateBase.Data.IDataClass;
using AspNetCore.Demo.Enterprise.DateBase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Text;

namespace AspNetCore.Demo.Enterprise.DateBase.Data.DataClass
{
    public class UserData: DataBase<User>,IUserData
    {
        public int Update(User user)
        {
            if (user.ID == 0) return 0;   
            var parameters = new DynamicParameters();
            var updateStr = new StringBuilder();

            
            updateStr.Append("ID=@ID");
            parameters.Add("@ID", user.ID);


            var sqlStr = string.Format("update User set {0} where ID=@ID",updateStr);
            return dbConnection.connection.Execute(sqlStr,parameters);
        }
    }
}
