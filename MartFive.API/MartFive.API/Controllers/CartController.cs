using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MartFive.API.Dal;

namespace MartFive.API.Controllers
{
    public class CartController : ApiController
    {
        /*[HttpPost]
        public List<Models.Cart> ShowCart(Models.User usr)
        {
            CartDal cartdal = new CartDal();
            return cartdal.ShowCart(usr);
        }

        [HttpPost]
        public bool AddToCart(Models.Cart cart)
        {
            CartDal cartdal = new CartDal();
            return cartdal.AddToCart(cart);
        }

        [HttpPost]
        public bool IncreaseQuantity(Models.Cart cart)
        {
            CartDal cartdal = new CartDal();
            return cartdal.IncreaseQuantity(cart);
        }

        [HttpPost]
        public bool DecreaseQuantity(Models.Cart cart)
        {
            CartDal cartdal = new CartDal();
            return cartdal.DecreaseQuantity(cart);
        }

        [HttpPost]
        public bool DeleteItem(Models.Cart cart)
        {
            CartDal cartdal = new CartDal();
            return cartdal.DeleteItem(cart);
        }*/
    }
}
