using login_new.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace login_new.Controllers
{

    public class LoginController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        // SqlDataReader sdr;
        //GET: NeedAccount
        [HttpGet]
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source = DESKTOP-URJ033D ; database = Login ; integrated security = SSPI;";
            //con.ConnectionString = "data source = LocalDB ; database = LoginDb ; integrated security = SSPI;";
            // con.ConnectionString = "Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "E:\Education\3.2\sd\visual studio project\Test\login_new\login_new\App_Data\LoginDb.mdf"; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework"
        }
        [HttpPost]
        /*
        public String test() {
            return "I am the database & i am on";
        }
        
        public ActionResult Create()
        {
            return View();
        }*/
        public ActionResult verify(Account na)
        {

            connectionString();
            con.Open();
            com.Connection = con;
           // com.CommandText = "Select * from [user] where User_Id = '" + na.User_id + "' and pass = '" + na.pass + "' ";
            com.CommandText = "INSERT INTO Story (Story_Id, Status) VALUES('" + na.User_id + "', '" + na.pass + "'); ";
            // SqlDataReader sdr = com.ExecuteReader();

            // return "I am the database & i am on";
            //test();
            //return View();
            /*
            if (sdr.Read())
            {
                con.Close();
                return View("Error");
            }
            else
            {
                con.Close();
                return View("Create");
            }*/
            //   sdr.Close();
            return View(); 
        }
    }
}