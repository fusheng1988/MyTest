using Hu.Liang.Interface;
using Hu.Liang.Tools;
using Hu.Liang.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
         var a=    DIContianer.Resolve<IUser>().GetViewUser("11"); 
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginUser u)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Reg()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Reg()
        //{
        //    return View();
        //}



    }
}