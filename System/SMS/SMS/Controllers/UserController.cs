using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using SMS.DB;

namespace SMS.Controllers
{
    public class UserController : Controller
    {
        DBConnection db = new DBConnection();

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult saveuser(string name,string email)
        {
            string val1 = "test";
            try
            {
                string name1 = name;
                string email1 = email;
                string val = "first call";
                //return Json(val, JsonRequestBehavior.AllowGet);

                string query = "insert into users(username,Password) values('" + name1 + "','" + email + "')";
                if (db.insert(query) == "success")
                {
                    return Json(val, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json("failed", JsonRequestBehavior.AllowGet);
                }
                /*
                DBConnection db = new DBConnection();
                SqlConnection conn = new SqlConnection();
                conn = db.GetConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into users(username,Password) values('" + name1 + "','" + email+"')",conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return Json(val, JsonRequestBehavior.AllowGet);
                */
            }
            catch(Exception ex)
            {

            }
            return Json(val1, JsonRequestBehavior.AllowGet); 
        }
        /*
          
        [HttpPost]
        public JsonResult saveuser()
        {
            string val = "first call";
            return Json(val, JsonRequestBehavior.AllowGet);
        }
         */

        public JsonResult GetImages(string id)
        {
            int i = Convert.ToInt32(id);
            // var img = (from a in prepository.GetProducts()
            //          select a);

            // img = img.Where(a => a.pId == i);

            string img = "a";

            return Json(img, JsonRequestBehavior.AllowGet);
        }

    }
}