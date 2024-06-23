using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using myproject.Models;

namespace myproject.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewEnquiry()
        {
            return View();
        }
public ActionResult viewRegistration()
        {
            return View();
        }
        public ActionResult ViewLogin()
{
    return View();
}
        [HttpGet]
        public ActionResult Changepassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChangePassword(string txtoldpass,string txtnewpass,string txtcpass)
        {
            try
            {
                string id = Session["aid"] + "";
                string cmd = "update Table_login set password='" + txtnewpass + "' where userid='" + id + "'";
                databasemManager db = new databasemManager();
                if (db.MyInsertUpdateDelete(cmd))
                    Response.Write("<script>alert('Admin Password change successfully')</script>");
                else
                    Response.Write("<script>alert(Unable to change password')</script>");
            }
            catch(Exception ex)
            {

            }
            return View();
        }
        public ActionResult LogOut()
        {
            return View();
        }
        public ActionResult UpEnquiry(string UP)
        {
            string cmd = "select * from tbl_contact where email='" + UP + "'";
            databasemManager db = new databasemManager();
            DataTable dt = db.GetAllRecords(cmd);
            if(dt.Rows.Count>0)
            {
                ViewBag.name = dt.Rows[0]["name"];
                ViewBag.email = dt.Rows[0]["email"];
                ViewBag.mobile = dt.Rows[0]["mobile"];
            }
            return View();
        }
        [HttpPost]
        public ActionResult  UpEnquiry(string txtname,string txtemail,string txtmobile)
        {
            string cmd = "update tbl_contact set name='" + txtname + "',mobile='" +txtmobile +"'where email='" + txtemail + "'";
            databasemManager db = new databasemManager();
            if (db.MyInsertUpdateDelete(cmd))
                Response.Write("<script>alert('Update Record successfully')</script>");
            else
                Response.Write("<script>alert('Unable to update records')</script>");
            return View();
        }
        public ActionResult DelEnquiry(string Del)
        {
            string cmd = "delete from tbl_contact where email='" + Del + "'";
            databasemManager db = new databasemManager();
            if(db.MyInsertUpdateDelete(cmd))
            {
                Response.Write("<script>alert('Data delete successfull');window.location.href='/Admin/ViewEnquiry'</script>");

            }
            else
            {
            Response.Write("<script>alert('Server erorr')</script>");
            }
        
         return View();
        
    }
}
}
