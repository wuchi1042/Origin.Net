using Origin.Bussines.Interface;
using Origin.Bussines.Service;
using Origin.Core.Json;
using Origin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Origin.Net.Areas.SystemManage.Controllers
{
    public class UserController : Controller
    {
        // GET: SystemManage/User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetUser()
        {
            using (IUserService user = new UserService())
            {
                return Content(user.GetUser().ToJson());
            }
        }
    }
}