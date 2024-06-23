using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myproject.Models;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace myproject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        databasemManager db = new databasemManager();

        public ActionResult Index()
        {
            return View();
        }
public ActionResult Login()
        {
    CaptchaGenerator cg=new CaptchaGenerator();
    ViewBag.cph=cg.CaptchaCode();
            return View();
        }
        [HttpPost]
public ActionResult Login(string txtid, string txtpass, string cph, string txtcph)
        {
            if(txtcph==cph)
            {
                string cmd = "select * from Table_login where userid='" + txtid + "'and password='" + txtpass + "'";
                DataTable dt= db.GetAllRecords(cmd);
                if(dt.Rows.Count>0)
                {
                    string type=dt.Rows[0]["utype"]+"";
                    if(type=="utype")
                    {
                        Session["uid"] = txtid;
                        Response.Redirect("/User/Index");
                    }
                    else if(type=="admin")
                    {
                        Session["aid"] = txtid;
                        Response.Redirect("/Admin/Index"); 
                    }
                    else
                    {
                        Response.Write("<script>alert('Pleas enter valid Email id')</script>");
                    }
                }
                else{

                
          Response.Write("<script>alert('Invalid userid and password')</script>");
                }
            }
            else{
                 Response.Write("<script>alert('Invalid Captcha')</script>");

            }
    return View();
}
      
        public ActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactUs(string txtname, string txtid, string txtmob, string txtmsg)
        {
            try
            {
                string cmd = "insert into tbl_contact values('" + txtname + "','" + txtid + "','" + txtmob + "','" + txtmsg + "','"+DateTime.Now.ToString()+"')";
                if (db.MyInsertUpdateDelete(cmd))
                    Response.Write("<script>alert('Enquiry save successfully')</script>");
                else
                    Response.Write("<script>alert('unable to save enquiry')</script>");
            }
            catch(Exception ex)
            {

            }
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(string txtname,string txtid,string txtmob,string ddlcountry,string txtpassword,HttpPostedFileBase fupic,string txtcpassword)
        {
            if(txtpassword==txtcpassword)
            {
                string path = Path.Combine(Server.MapPath("../Content/profile/"), fupic.FileName);
                fupic.SaveAs(path);
                string cmd = "insert into table_registration values('" + txtname + "','" + txtid + "','" + txtmob + "','" + txtpassword + "','" + ddlcountry + "','" + fupic.FileName + "','" + DateTime.Now.ToString() + "')";
                string cmd2 = "insert into table_login values('" + txtid + "','" + txtpassword + "','utype','" + DateTime.Now.ToString() + "')";
                if(db.MyInsertUpdateDelete(cmd) && db.MyInsertUpdateDelete(cmd2))
                    Response.Write("<script>alert('Registration successfully')</script>");
                else
                    Response.Write("<script>alert('unable to save data')</script>");
            }
            else
            {
                Response.Write("<script>alert('Password and confirm password not match')</script>");
            }
            return View();
        }
        public ActionResult Booking()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }

    }
}
