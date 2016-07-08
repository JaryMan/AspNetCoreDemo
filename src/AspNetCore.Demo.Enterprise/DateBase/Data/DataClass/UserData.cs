using AspNetCore.Demo.Enterprise.DateBase.Data.IDataClass;
using AspNetCore.Demo.Enterprise.DateBase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Demo.Enterprise.DateBase.Data.DataClass
{
    public class UserData: DataBase<User>,IUserData
    {

    }
}
