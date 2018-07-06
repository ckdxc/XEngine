using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XEngine.Models;

namespace XEngine.Repositories
{
    public interface ISysUserRepository : IDisposable
    {
        IEnumerable<SysUser> GetUsers();
        SysUser GetUserByID(int ID);

        void InsertUser(SysUser user);
        void UpdateUser(SysUser user);
        void DeleteUser(int userID);

        void Save();
    }
}