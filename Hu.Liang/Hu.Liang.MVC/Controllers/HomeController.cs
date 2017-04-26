using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hu.Liang.ViewModel;
namespace Hu.Liang.MVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/


        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {

                return Json(new { success = true, message = "验证成功", url = Url.Action("Index", "User") });
            }


            return  Json(new { success = false, message = "验证失败", url = "" });
        }

        [HttpPost]
        public ActionResult Reg(LoginUser user)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Reg()
        {
            return View();
        }


    }
}
