using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myproject.Models;

namespace myproject.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /user/

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult profile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult profile(string values)
        {
            return View();
        }
        [HttpGet]
        public ActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChangePassword(string txtopass, string txtnpass, string txtcpass)
        {
            databasemManager db = new databasemManager();
            string id = Session["uid"] + "";
            if (txtnpass == txtcpass)
            {
                string cmd = "update Table_login set password='" + txtnpass + "' where userid='" + id + "'and password='" + txtopass + "'";
                if (db.MyInsertUpdateDelete(cmd))
                    Response.Write("<script>alert('Password change successfully')</script>");
                else
                    Response.Write("<script>alert('server error')</script>");
              
            }
            return View();
        }
    }
}

