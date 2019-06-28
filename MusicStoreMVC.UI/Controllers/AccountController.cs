using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreMVC.UI.Controllers
{
    public class AccountController : Controller
    {
        IUserService userServici;
        public AccountController(IUserService UserService)
        {

        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}