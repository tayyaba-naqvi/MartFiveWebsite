using MartFive.API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MartFive.Controllers
{
    public class HomeController : Controller
    {
        string Baseurl = "http://localhost:57317/api";
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public string RegisterUserAjax(string u_firstName, string u_lastName, string u_password, string u_email, string u_phone)
        {
            if (u_firstName != null && u_lastName != null && u_password != null && u_email != null && u_phone != null)
            {
                using (LINQMartFiveDataContext objDataContext = new LINQMartFiveDataContext())
                {
                    User objUsr = new User();
                    // fields to be insert
                    objUsr.User_Email = u_email;
                    objUsr.User_Password = u_password;
                    objUsr.First_Name = u_firstName;
                    objUsr.Last_Name = u_lastName;
                    objUsr.User_Phone = u_phone;
                    objDataContext.Users.InsertOnSubmit(objUsr);
                    // executes the commands to implement the changes to the database
                    objDataContext.SubmitChanges();
                };
                return "Data aagya";
            }

            return "Success";
        }
        public string LoginUserAjax(string u_password, string u_email)
        {
            string login = "false";
            if (u_password != null && u_email != null)
            {
                using (LINQMartFiveDataContext objDataContext = new LINQMartFiveDataContext())
                {
                    var result = from c in objDataContext.Users
                                 where c.User_Password.Equals(u_password) && c.User_Email.Equals( u_email)
                                 select c;

                    User u = result.First<User>();

                    if (u!= null && u.First_Name != null && u.First_Name.Length != 0 && u.Last_Name != null && u.Last_Name.Length != 0 && u.User_Email != null && u.User_Email.Length != 0 && u.User_Password != null && u.User_Password.Length != 0 && u.User_Phone != null && u.User_Phone.Length != 0)
                    {
                        Session["user"] = u;
                        Session["user_id"] = u.User_Id;

                        
                        login = u.User_Id.ToString();
                    }
                };
                return login;
            }

            return login;
        }

        /*
        public async Task<ActionResult> SaveMazdoorAjax(Mazdoor model)
        {

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var myContent = JsonConvert.SerializeObject(model);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.PostAsync("Mazdoor/SaveMazdoor", byteContent);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    model = JsonConvert.DeserializeObject<Mazdoor>(EmpResponse);

                }

            }
            return Json("success", JsonRequestBehavior.AllowGet);


        }*/

        public ActionResult Shop()
        {
            return View();
        }
        //public async Task<ActionResult> ProductDetails()
        //{
        //    List<Item> list = null;
        //    using (var client = new HttpClient())
        //    {
        //        //Passing service base url  
        //        client.BaseAddress = new Uri(Baseurl);

        //        client.DefaultRequestHeaders.Clear();
        //        //Define request data format  
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
        //        HttpResponseMessage Res = await client.GetAsync("Item/addItem");

        //        //Checking the response is successful or not which is sent using HttpClient  
        //        if (Res.IsSuccessStatusCode)
        //        {
        //            //Storing the response details recieved from web api   
        //            var EmpResponse = Res.Content.ReadAsStringAsync().Result;

        //            //Deserializing the response recieved from web api and storing into the Employee list  
        //            list = JsonConvert.DeserializeObject<List<Item>>(EmpResponse);

        //        }

        //    }
        //    return View(list);
        //}

        public ActionResult ProductDetails()
        {

            string itemID = Request.QueryString["id"];
            if(itemID == null)
            {
                itemID = "1";
            }
            using (LINQMartFiveDataContext objDataContext = new LINQMartFiveDataContext())
                {
                var result = from c in objDataContext.Items
                             where c.Item_Id.Equals(itemID) 
                             select c;
                List<Item> items = result.ToList();
                ViewBag.item = items.First();

                var res = from a in objDataContext.Pictures
                          where a.Pic_Id.Equals(items.First().Pic_Id)
                          select a;
                List<Picture> pic = res.ToList();
                ViewBag.pic = pic.First();
                };
            
            return View();

        }

        public ActionResult MyCart()
        {
            return View();
        }
        public string AddToCartAjax(Cart c)
        {
            return "ok";
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult Category()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ForgetPassword()
        {
            return View();
        }
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        public ActionResult Delivery()
        {
            return View();
        }
        public ActionResult SecurePayment()
        {
            return View();
        }
        public ActionResult TermsAndConditions()
        {
            return View();
        }
    }
}