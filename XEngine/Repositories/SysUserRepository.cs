using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XEngine.DAL;
using XEngine.Models;
using System.Data.Entity;

namespace XEngine.Repositories
{
    public class SysUserRepository : ISysUserRepository
    {
        private XEngineContext context = new XEngineContext();
        public SysUserRepository(XEngineContext context)
        {
            this.context = context;
        }
        public void DeleteUser(int userID)
        {
            SysUser sysUser = context.SysUsers.Find(userID);
            context.SysUsers.Remove(sysUser);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public SysUser GetUserByID(int userID)
        {
            return context.SysUsers.Find(userID);
        }

        public IEnumerable<SysUser> GetUsers()
        {
            return context.SysUsers.ToList();
        }

        public void InsertUser(SysUser user)
        {
            context.SysUsers.Add(user);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateUser(SysUser user)
        {
            context.Entry(user).State = EntityState.Modified;
        }
    }
}