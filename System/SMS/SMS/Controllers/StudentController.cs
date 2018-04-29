using SMS.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMS.Controllers
{
    public class StudentController : Controller
    {
        DBConnection db = new DBConnection();

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SaveStudent(string name, string email)
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
            catch (Exception ex)
            {

            }
            return Json(val1, JsonRequestBehavior.AllowGet);
        }

    }
}