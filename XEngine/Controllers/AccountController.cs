using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace XEngine.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            FormsAuthentication.SignOut();
            TempData["ReturnUrl"] = Convert.ToString(Request["ReturnUrl"]);
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            //获取表单数据
            string userName = fc["inputUserName"];
            string passWord = fc["inputPassword"];
            string encryptPwd =
                return View();
        }
    }
}