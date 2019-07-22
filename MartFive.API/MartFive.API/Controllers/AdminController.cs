using Admin_Panel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Admin_Panel.Controllers
{
    public class AdminController : Controller
    {
        string Baseurl = "http://localhost:57317/api";
        // GET: Admin
        public ActionResult Index()
        {
            return View("AdminHome");
        }
        public ActionResult Orders()
        {
            return View();
        }
        public ActionResult Add_Item()
        {
            return View();
        }
       

       

        [HttpGet]
        public ActionResult AddItems()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddItems(Item  model)
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
                HttpResponseMessage Res = await client.PostAsync("ItemController/AddItem", byteContent);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    model = JsonConvert.DeserializeObject<Item>(EmpResponse);

                }

            }
            RedirectToAction("Index");
            return View();
        }


            
      

        



        [HttpGet]
        public async Task<ActionResult> viewItems()
        {
            List<Item> list = null;
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
        
                HttpResponseMessage Res = await client.GetAsync("ItemController/ShowAllItems");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    list = JsonConvert.DeserializeObject<List<Item>>(EmpResponse);

                }

            }
            return View(list);
        }

        [HttpPost]
        public async Task<ActionResult> Update(int id)
        {
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var myContent = JsonConvert.SerializeObject(id);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.PostAsync("ItemController/AddItem", byteContent);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    //id = JsonConvert.DeserializeObject<int>(EmpResponse);

                }

            }
            RedirectToAction("Orders");
            return View();
        }


        [HttpGet]
        public async Task<ActionResult> viewOrderds()
        {

            List<OrderAdmin> list = null;
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("OrderAdminController/GetList");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    list = JsonConvert.DeserializeObject<List<OrderAdmin>>(EmpResponse);

                }

            }
            return View(list);
            
        }
    }
}