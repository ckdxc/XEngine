using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XEngine.Repositories;
using XEngine.DAL;
using XEngine.Models;

namespace XEngine.Controllers
{
    public class UserController : Controller
    {
        //private ISysUserRepository sysUserRepository = new SysUserRepository(new XEngineContext());
        //// GET: User
        //public ActionResult Index()
        //{
        //    var users = sysUserRepository.GetUsers();
        //    return View(users);
        //}

        private IGenericRepository<SysUser> userRepository = new GenericRepository<SysUser>(new XEngineContext());
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: User
        public ActionResult Index()
        {
            //var users = userRepository.Get();
            var users = unitOfWork.SysUserRepository.Get(orderBy: q => q.OrderBy(u => u.Name));
            return View(users);
        }
    }
}